using AdventureWorksAspMvcUI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SharePoint.News.DataModel;
using Microsoft.AspNetCore.Session;
using AdventureWorksAspMvcUI.Helpers;
using System.Linq;
using PayPal.Api;
using System.Web.Providers.Entities;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Item = PayPal.Api.Item;
using System.Configuration;
using AdventureWorksAspMvcClassLibrary.DataAccess;
using Newtonsoft.Json.Converters;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Text.Encodings.Web;

namespace AdventureWorksAspMvcUI.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        IConfiguration _configuration;

        private IHttpContextAccessor _contextAccessor;

        private List<ShoppingCartModel> _listCart = new();

        public ShoppingCartController(IHttpContextAccessor contextAccessor, IConfiguration configuration)
        {
            _contextAccessor = contextAccessor;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ModelState.Clear();
            ViewBag.emptyCart = 0;

            _listCart = _contextAccessor.HttpContext.Session.Get<List<ShoppingCartModel>>("Cart");

            if (_listCart != null)
            {
                ViewBag.Subtotal = (_listCart.Sum(x => x.ListPrice * x.Qty)).ToString("C");
            }
            else
            {
                _listCart = new List<ShoppingCartModel>();
            }

            if (_listCart.Count == 0)
            {
                ViewBag.emptyCart = 1;
            }

            return View("Views/Home/ShoppingCart.cshtml", _listCart);
        }

        // GET: Add Item to Cart
        public ActionResult AddToCart(int Id, string Name, string ProductNumber, string Description, int Qty, decimal ListPrice)
        {
 
            var session = _contextAccessor.HttpContext.Session.Get<List<ShoppingCartModel>>("Cart");

            ShoppingCartModel cart = new();

            if (session != null)
            {
                var list = session.Find(x => x.Id == Id);

                if (list != null)
                {
                    var index = session.FindIndex(x => x.Id == Id);

                    session[index].Qty = session[index].Qty + Qty;

                    foreach (ShoppingCartModel model in session)
                    {
                        _listCart.Add(model);
                    }
                }
                else
                {
                    cart.Id = Id;
                    cart.Name = Name;
                    cart.ProductNumber = ProductNumber;
                    cart.Description = Description;
                    cart.Qty = Qty;
                    cart.ListPrice = ListPrice;

                    foreach (ShoppingCartModel model in session)
                    {
                        _listCart.Add(model);
                    }
                    _listCart.Add(cart);
                }
            }

            else
            {
                cart.Id = Id;
                cart.Name = Name;
                cart.ProductNumber = ProductNumber;
                cart.Description = Description;
                cart.Qty = Qty;
                cart.ListPrice = ListPrice;

                _listCart.Add(cart);
            }

            _contextAccessor.HttpContext.Session.Set<List<ShoppingCartModel>>("Cart", _listCart);

            return RedirectToAction("Index", "ShoppingCart");
        }

        // GET: Remove Item from Cart
        public ActionResult RemoveFromCart(ShoppingCartModel item)
        {

            var session = _contextAccessor.HttpContext.Session.Get<List<ShoppingCartModel>>("Cart");

            if (session != null)
            {
                foreach (ShoppingCartModel model in session)
                {
                    _listCart.Add(model);
                }

                var remove = _listCart.Find(x => x.Id == item.Id && x.Name == item.Name && x.ProductNumber == item.ProductNumber &&
                x.Description == item.Description && x.Qty == item.Qty && x.ListPrice == item.ListPrice);

                _listCart.Remove(remove);

                _contextAccessor.HttpContext.Session.Set<List<ShoppingCartModel>>("Cart", _listCart);
            }

            return RedirectToAction("Index", "ShoppingCart");
        }

        private PayPal.Api.Payment payment;

        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId,
            };
            this.payment = new Payment()
            {
                id = paymentId,
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }

        private Payment CreatePayment(APIContext apiContext, string redirectUrl, string blogId)
        {
            _listCart = _contextAccessor.HttpContext.Session.Get<List<ShoppingCartModel>>("Cart");

            var tax = Math.Round((_listCart.Sum(x => x.ListPrice * x.Qty) * .07m), 2).ToString();
            int shipping = 50;
            var subtotal = Math.Round((_listCart.Sum(x => x.ListPrice * x.Qty)), 2).ToString();
            var total = Math.Round((_listCart.Sum(x => x.ListPrice * x.Qty) * .07m) + shipping + (_listCart.Sum(x => x.ListPrice * x.Qty)), 2).ToString();
            var itemList = new ItemList()
            {
                items = new List<Item>()
            };

            foreach (var item in _listCart)
            {
                itemList.items.Add(new Item()
                {
                    name = item.Name,
                    currency = "USD",
                    price = Math.Round(item.ListPrice, 2).ToString(),
                    quantity = item.Qty.ToString(),
                    sku = item.Id.ToString(),
                });
            };
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            var redirUrls = new RedirectUrls()
            {
                cancel_url = "https://localhost:7176/ShoppingCart",
                return_url = redirectUrl
            };
            var details = new Details()
            {
                tax = tax,
                shipping = shipping.ToString(),
                subtotal = subtotal,
            };
            var amount = new Amount()
            {
                currency = "USD",
                total = total,
                details = details
            };
            var transactionList = new List<Transaction>();
            transactionList.Add(new Transaction()
            {
                description = "Transaction Description",
                invoice_number = Guid.NewGuid().ToString(),
                amount = amount,
                item_list = itemList
            });
            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };
            return this.payment.Create(apiContext);
        }

        //GET: Payment with Paypal
        public ActionResult PaymentWithPaypal(string Cancel = null, string blogId = "", string PayerID = "", string guid = "")
        {
            var cart = _contextAccessor.HttpContext.Session.Get<List<ShoppingCartModel>>("Cart");
            
            if(cart == null)
            {
                return RedirectToAction("Index", "ShoppingCart");
            }

            var ClientID = this._configuration["PayPal:ClientID"];
            var Secret = this._configuration["PayPal:Secret"];
            var mode = this._configuration["PayPal:mode"];
            APIContext apiContext = PaypalConfiguration.GetAPIContext(ClientID, Secret, mode);

            try
            {
                string payerId = PayerID;
                if (string.IsNullOrEmpty(payerId))
                {
                    string baseURI = this.Request.Scheme + "://" + this.Request.Host + "/ShoppingCart/PaymentWithPaypal?";

                    var guidd = Convert.ToString((new Random()).Next(100000));
                    guid = guidd;

                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid, blogId);

                    var links = createdPayment.links.GetEnumerator();
                    string paypalRedirectUrl = null;
                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;
                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            paypalRedirectUrl = lnk.href;
                        }
                    }
                    _contextAccessor.HttpContext.Session.SetString("payment", createdPayment.id);
                    return Redirect(paypalRedirectUrl);
                }
            }
            catch (Exception ex)
            {

                ViewBag.Paypal = 0;
                return View("/Views/Home/PayPalPayment.cshtml");
            }
            //return View("/Views/Home/PayPalPayment.cshtml");
            var model = _contextAccessor.HttpContext.Session.Get<List<ShoppingCartModel>>("Cart");
            _contextAccessor.HttpContext.Session.Set("payerId", PayerID);
            ViewBag.PayPalConfirm = 1;
            return View("/Views/Home/ShoppingCart.cshtml", model);
        }

        //GET: Payment with Paypal
        public ActionResult ConfirmPayPal()
        {
            var model = new AdventureWorksAspMvcClassLibrary.Models.SalesOrderModel();
            var Detail = new AdventureWorksAspMvcClassLibrary.Models.SalesOrderDetailModel();
            var vendorModel = new AdventureWorksAspMvcClassLibrary.Models.VendorSalesOrderModel();
            var ClientID = this._configuration["PayPal:ClientID"];
            var Secret = this._configuration["PayPal:Secret"];
            var mode = this._configuration["PayPal:mode"];
            APIContext apiContext = PaypalConfiguration.GetAPIContext(ClientID, Secret, mode);

            try
            {
                var payerId = _contextAccessor.HttpContext.Session.Get<string>("payerId");
                var paymentId = _contextAccessor.HttpContext.Session.GetString("payment");
                var executedPayment = ExecutePayment(apiContext, payerId, paymentId as string);
                if (executedPayment.state.ToLower() != "approved")
                {
                    ViewBag.Paypal = 0;
                    return View("/ViewsHome/PayPalPayment.cshtml");
                }

                if (User.IsInRole("Vendor"))
                {
                    var payer = executedPayment.payer.payer_info;

                    vendorModel.FirstName = payer.first_name;
                    vendorModel.MiddleName = payer.middle_name;
                    vendorModel.LastName = payer.last_name;
                    vendorModel.ShipMethod = "ZY - EXPRESS";
                    vendorModel.Freight = decimal.Parse(executedPayment.transactions[0].amount.details.shipping);

                    SqlDataAccess.VendorSalesOrder(vendorModel);

                    var itemList = executedPayment.transactions[0].item_list.items.ToList();

                    foreach (var item in itemList)
                    {
                        Detail.SalesOrderID = vendorModel.SalesOrderID;
                        Detail.OrderQty = Int32.Parse(item.quantity);
                        Detail.ProductID = Int32.Parse(item.sku);
                        Detail.UnitPrice = decimal.Parse(item.price);
                        SqlDataAccess.SalesOrderDetail(Detail);
                    }
                }

                else
                {
                    var payer = executedPayment.payer.payer_info;
                    var address = payer.shipping_address;

                    model.Suffix = payer.suffix;
                    model.FirstName = payer.first_name;
                    model.LastName = payer.last_name;
                    model.PhoneNumber = payer.phone;
                    model.Email = payer.email;
                    model.AddressLine1 = address.line1;
                    model.City = address.city;
                    model.State = address.state;
                    model.PostalCode = address.postal_code;
                    model.ShipMethod = "ZY - EXPRESS";
                    model.Freight = decimal.Parse(executedPayment.transactions[0].amount.details.shipping);

                    SqlDataAccess.SalesOrder(model);

                    var itemList = executedPayment.transactions[0].item_list.items.ToList();

                    foreach (var item in itemList)
                    {
                        Detail.SalesOrderID = model.SalesOrderID;
                        Detail.OrderQty = Int32.Parse(item.quantity);
                        Detail.ProductID = Int32.Parse(item.sku);
                        Detail.UnitPrice = decimal.Parse(item.price);
                        SqlDataAccess.SalesOrderDetail(Detail);
                    }
                }

                ViewBag.Paypal = 1;
                _listCart.Clear();
                _contextAccessor.HttpContext.Session.Set<List<ShoppingCartModel>>("Cart", _listCart);
                ViewBag.PayPalConfirm = 0;
                return View("/Views/Home/PayPalPayment.cshtml");
            }
            catch (Exception ex)
            {
                ViewBag.Paypal = 0;
                return View("/Views/Home/PayPalPayment.cshtml");
            }
        }
    }
}