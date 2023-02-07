using System;
/// <summary>
/// Class <c>Cards</c> models a deck of poker cards.
/// </summary>
namespace CardClass
{
    /// <summary>
    /// Enum <c>CardSuit</c> contains the potential suits of the cards.
    /// </summary>
    public enum CardSuit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    /// <summary>
    /// Interface <c>Cards</c> stubbs out the desired functionality of the Cards class
    /// </summary>
    public interface ICards
    {
        /// <summary>
        /// Method <c>GetCardSuit</c> gets the suit of a card
        /// </summary>
        CardSuit GetCardSuit();


        /// <summary>
        /// Method <c>GetCardNumber</c> gets the number of a card
        /// </summary>
        int GetCardNumber();
    }

    /// <summary>
    /// Class <c>Cards</c> implments the desired functionality of the Cards class
    /// </summary>
    public class Card : ICards
    {
        private CardSuit Suit;
        private int Number;
        public Card(CardSuit suit, int number)
        {
            this.Suit = suit;
            this.Number = number;
        }


        /// <summary>
        /// Method <c>GetCardSuit</c> gets the suit of a card
        /// </summary>
        public CardSuit GetCardSuit()
        {
            return this.Suit;
        }


        /// <summary>
        /// Method <c>GetCardNumber</c> gets the number of a card
        /// </summary>
        public int GetCardNumber()
        {
            return this.Number;
        }

        /// <summary>
        /// Method <c>Main</c> creates an ace of hearts
        /// </summary>
        public static void Main()
        {
            Card cards = new Card(CardSuit.Diamonds, 2);
        }
    }

    /// <summary>
    /// Class <c>CardDeck</c> implments the desired functionality of the CardDeck class
    /// </summary>
    public class CardDeck
    {
        public List<Card> Cards;
        public CardDeck? cardDeck;
        public CardDeck()
        {
            Cards = new List<Card>();
            var suits = Enum.GetValues(typeof(CardSuit));
            /// for each potential card suit
            foreach (CardSuit suit in suits)
            {
                /// iterate through the 13 potential cards
                for (int i = 1; i <= 13; i++)
                    /// add a new card with the suit and the next number
                    Cards.Add(new Card(suit, i));
            }
        }

        /// <summary>
        /// Method <c>ShuffleCard</c> returns no value but results in the cards in the deck being randomly permuted 
        /// </summary>
        public void Shuffle()
        {
            /// initalize new instance of the random class
            Random random = new Random();
            /// for every possible card in the deck (52 cards)
            for (int i = 0; i < 52; i++)
            {
                /// randomly select a number
                int j = random.Next(0, 51);
                /// set a temporary card to the current card
                Card tempCard = Cards[i];
                /// replace the current card with the randomly selected card
                Cards[i] = Cards[j];
                /// set the randomly selected card to the temporary card
                Cards[j] = tempCard;
            }
        }

        /// <summary>
        /// Method <c>DealOneCard</c> return one card from the deck to the caller. If all cards have been dealt, no card is returned.
        /// </summary>
        /// <returns>One card from the deck to the caller</returns>
        public Card? DealOneCard()
        {
            /// if there are any cards remaining in the deck
            if (Cards.Any())
            {
                /// draw the first card
                Card firstCard = Cards[0];
                /// remove the first card
                Cards.RemoveAt(0);
                /// return the first card
                return firstCard;
            }
            /// otherwise return null
            return null;
        }
    }
}