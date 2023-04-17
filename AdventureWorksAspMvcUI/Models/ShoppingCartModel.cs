namespace AdventureWorksAspMvcUI.Models
{
    public class ShoppingCartModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public decimal ListPrice { get; set; }
    }
}
