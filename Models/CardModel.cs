//namespace DeckOfCardsAPI.Models
//{
//    public class CardModel
//    {
//    }
//}
namespace DeckOfCardsAPI.Models
{

    public partial class DeckOfCards
    {
        public bool Success { get; set; }
        public string DeckId { get; set; }
        public List<Card> Cards { get; set; }
        public long Remaining { get; set; }
    }


    public partial class ShuffledDeck
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public bool shuffled { get; set; }
        public int remaining { get; set; }
    }


    public partial class Card
    {
        public string Code { get; set; }
        public Uri Image { get; set; }
        public Images Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }

    public partial class Images
    {
        public Uri Svg { get; set; }
        public Uri Png { get; set; }
    }
}
