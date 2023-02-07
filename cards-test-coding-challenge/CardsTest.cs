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
        /// Method <c>CreateCard</c> tests the creation of a one of hearts.
        /// </summary>
        [TestMethod]
        public void CreateCard()
        {
            /// Create expected results and the test card
            CardSuit expectedSuit = CardSuit.Hearts;
            int expectedNumber = 1;
            Card testCard = new Card(CardSuit.Hearts, 1);

            /// Get the card suit and number
            CardSuit actualSuit = testCard.GetCardSuit();
            int actualNumber = testCard.GetCardNumber();

            Assert.AreEqual(expectedSuit, actualSuit, "The card suit was not set as expected.");
            Assert.AreEqual(expectedNumber, actualNumber, "The card number was not set as expected.");
        }
    }
}