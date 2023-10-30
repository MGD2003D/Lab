using Xunit;
using OOP_ICT.Models;

namespace OOP_ICT.Tests
{
    public class DealerTests
    {
        [Fact]
        public void DealerConstructor_CreatesDeckWithPerfectShuffle()
        {
            // Act
            var dealer = new Dealer();
            var deckState = dealer.ShowDeck();

            var expectedDeckState = "5 of Hearts, 1 of Hearts, 6 of Hearts, 2 of Hearts, 7 of Hearts, 3 of Hearts, 8 of Hearts, 4 of Hearts, ..."; 

            // Assert
            Assert.Equal(expectedDeckState, deckState);
        }

        [Fact]
        public void DealCard_RemovesTopCardFromDeck()
        {
            // Arrange
            var dealer = new Dealer();
            var initialDeckState = dealer.ShowDeck();

            // Act
            var dealtCard = dealer.DealCard();
            var afterDealingDeckState = dealer.ShowDeck();

            // Assert
            Assert.DoesNotContain(dealtCard.ToString(), afterDealingDeckState);
            Assert.NotEqual(initialDeckState, afterDealingDeckState);
        }
    }
}
