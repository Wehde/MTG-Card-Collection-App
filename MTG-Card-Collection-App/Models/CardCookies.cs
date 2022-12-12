namespace MTG_Card_Collection_App.Models
{
    public class CardCookies
    {
        private const string CARDS_KEY = "mycards";
        private const string DELIMETER = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public CardCookies(IRequestCookieCollection requestCookies)
        {
            this.requestCookies = requestCookies;
        }

        public CardCookies(IResponseCookies responseCookies)
        {
            this.responseCookies = responseCookies;
        }

        public void SetMyCardIds(List<Card> mycards)
        {
            List<string> ids = mycards.Select(c => c.Id).ToList();
            string idsString = String.Join(DELIMETER, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(60) };
            RemoveMyCardIds();
            responseCookies.Append(CARDS_KEY, idsString, options);
        }

        public string[] GetMyCardIds()
        {
            string cookie = requestCookies[CARDS_KEY];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };
            else
                return cookie.Split(DELIMETER);
        }

        public void RemoveMyCardIds()
        {
            responseCookies.Delete(CARDS_KEY);
        }
    }
}
