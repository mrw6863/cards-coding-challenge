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

        public static void Main()
        {
            Card cards = new Card(CardSuit.Hearts, 1);
        }
    }
}