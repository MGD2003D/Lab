using Xunit;
using OOP_ICT.Models;

namespace OOP_ICT.Tests
{
    public class CardTests
    {
        [Fact]
        public void CardConstructor_SetsSuitAndRank()
        {
            // Arrange
            var expectedSuit = Card.Suit.Hearts;
            var expectedRank = Card.Rank.Ace;

            // Act
            var card = new Card(expectedSuit, expectedRank);

            // Assert
            Assert.Equal(expectedSuit, card.CardSuit);
            Assert.Equal(expectedRank, card.CardRank);
        }
    }
}
