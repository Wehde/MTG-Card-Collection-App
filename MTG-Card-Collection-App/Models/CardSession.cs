namespace MTG_Card_Collection_App.Models
{
    public class CardSession
    {
        private const string CARDS_KEY = "mycards";
        private const string COUNT_KEY = "cardcount";

        private ISession session { get; set; }
        public CardSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCards(List<Card> cards)
        {
            session.SetObject(CARDS_KEY, cards);
            session.SetInt32(COUNT_KEY, cards.Count);
        }

        public List<Card> GetMyCards() => session.GetObject<List<Card>>(CARDS_KEY) ?? new List<Card>();

        public int? GetMyCardCount() => session.GetInt32(COUNT_KEY);

        public void RemoveMyCards()
        {
            session.Remove(CARDS_KEY);
            session.Remove(COUNT_KEY);
        }
    }
}
