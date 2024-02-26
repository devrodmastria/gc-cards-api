using System.Net;
using Newtonsoft.Json;

namespace DeckOfCardsAPI.Models
{
    public class CardsDAL
    {
        public static DeckOfCards GetCards()
        {
            string url = $"https://deckofcardsapi.com/api/deck/{Secret.DeckID}/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();
            DeckOfCards result = JsonConvert.DeserializeObject<DeckOfCards>(JSON);

            return result;
        }

        public static DeckOfCards Shuffle()
        {

            string url = $"https://deckofcardsapi.com/api/deck/new/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();
            ShuffledDeck result = JsonConvert.DeserializeObject<ShuffledDeck>(JSON);

            string newDeckID = result.deck_id;

            Secret.DeckID = newDeckID;

            return GetCards();
        }
    }
}
