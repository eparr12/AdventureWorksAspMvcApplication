using PayPal.Api;

namespace AdventureWorksAspMvcUI.Helpers
{
public static class PaypalConfiguration
    {
        static PaypalConfiguration()
        {

        }

        public static Dictionary<string, string> GetConfig(string mode) 
        {
            return new Dictionary<string, string>()
            {
                {"mode", mode }
            };
        }

        private static string GetAccessToken(string ClientID, string Secret, string mode)
        {
            string accessToken = new OAuthTokenCredential(ClientID,Secret, new Dictionary<string, string>()
            {
                {"mode", mode }
            }).GetAccessToken();
            return accessToken;
        }

        public static APIContext GetAPIContext(string clientID, string secret, string mode) 
        {
            APIContext apiContext = new APIContext(GetAccessToken(clientID, secret, mode));
            apiContext.Config = GetConfig(mode);
            return apiContext;
        }
    }
}
