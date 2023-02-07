using System;
using CardClass;

/// <summary>
/// Namespace <c>CardsTests</c> contains the testing features of the Cards class.
/// </summary>
namespace CardsTests
{
    [TestClass]
    public class CardTests
    {

        /// <summary>
        /// Test <c>CreateCardTest</c> tests the creation of a one of hearts.
        /// </summary>
        [TestMethod]
        public void CreateCardTest()
        {
            /// Create expected results and the test card
            Card testCard = new Card(CardSuit.Hearts, 1);

            Assert.IsNotNull(testCard);
        }


        /// <summary>
        /// Test <c>GetCardSuitTest</c> tests getting a card suit
        /// </summary>
        [TestMethod]
        public void GetCardSuitTest()
        {
            /// Create expected results and the test card
            CardSuit expectedSuit = CardSuit.Hearts;
            Card testCard = new Card(CardSuit.Hearts, 1);

            /// Get the card suit
            CardSuit actualSuit = testCard.GetCardSuit();

            Assert.AreEqual(expectedSuit, actualSuit, "The card suit was not set as expected.");
        }


        /// <summary>
        /// Test <c>GetCardNumberTest</c> tests getting a card number
        /// </summary>
        [TestMethod]
        public void GetCardNumberTest()
        {
            /// Create expected results and the test card
            int expectedNumber = 1;
            Card testCard = new Card(CardSuit.Hearts, 1);

            /// Get the card number
            int actualNumber = testCard.GetCardNumber();

            Assert.AreEqual(expectedNumber, actualNumber, "The card number was not set as expected.");
        }
    }


    [TestClass]
    public class DeckTests
    {
        /// <summary>
        /// Test <c>CreateDeckTest</c> tests the creation of a deck of cards to be null.
        /// </summary>
        [TestMethod]
        public void CreateDeckTest()
        {
            /// Create test deck
            CardDeck cardDeck = new CardDeck();

            // assert the card deck is not null
            Assert.IsNotNull(cardDeck);
        }


        /// <summary>
        /// Test <c>ShuffleDeckTest</c> tests if a deck is shuffled
        /// </summary>
        [TestMethod]
        public void ShuffleDeckTest()
        {
            /// Create expected results and the test deck
            CardDeck cardDeck = new CardDeck();
            CardDeck shuffledCardDeck = new CardDeck();

            // shuffle the card deck
            shuffledCardDeck.Shuffle();

            // assert the shuffled card deck is not the same as the unshuffled card deck
            Assert.AreNotEqual(cardDeck, shuffledCardDeck, "The shuffled and unshuffled card deck are the same");
        }


        /// <summary>
        /// Test <c>DealOneCardUnshuffledTest</c> tests if one card is dealt and removed from the deck unshuffled
        /// </summary>
        [TestMethod]
        public void DealOneCardUnshuffledTest()
        {
            /// Create expected results and the test deck
            CardDeck cardDeck = new CardDeck();

            // deal one card
            Card? dealtCard = cardDeck.DealOneCard();

            // assert the returned card is not null and that the deck does not contain the dealt card
            Assert.IsNotNull(dealtCard);
            Assert.IsFalse(cardDeck.Cards.Contains(dealtCard));
        }


        /// <summary>
        /// Test <c>DealOneCardShuffledTest</c> tests if one card is dealt and removed from the deck shuffled
        /// </summary>
        [TestMethod]
        public void DealOneCardShuffledTest()
        {
            /// Create expected results and the test deck
            CardDeck cardDeck = new CardDeck();

            /// shuffle the card deck
            cardDeck.Shuffle();
            Card? dealtCard = cardDeck.DealOneCard();

            /// assert the returned card is not null and that the deck does not contain the dealt card
            Assert.IsNotNull(dealtCard);
            Assert.IsFalse(cardDeck.Cards.Contains(dealtCard));
        }


        /// <summary>
        /// Test <c>DealOneCardShuffledTest</c> tests if one card is dealt and removed from the deck shuffled
        /// </summary>
        [TestMethod]
        public void DealAllCards()
        {
            /// Create expected results and the test deck
            CardDeck cardDeck = new CardDeck();
            List<Card> cards = new List<Card>();

            /// shuffle the card deck
            cardDeck.Shuffle();
            /// get the first card to test
            Card firstCard = cardDeck.DealOneCard();
            /// get the rest of the cards in the deck 
            for (int i = 0; i < 51; i++)
            {
                Card? dealtCard = cardDeck.DealOneCard();
                cards.Append(dealtCard);

            }
            /// get the last card after getting the whole deck (should be null)
            object lastCard = cardDeck.DealOneCard();


            /// assert the returned card is not null and that the deck does not contain the dealt card
            Assert.IsNull(lastCard);
            Assert.IsFalse(cardDeck.Cards.Contains(firstCard));
        }
    }
}