using CardGame.Domain.Tests.Fixtures;
using Xunit;

namespace CardGame.Domain.Tests
{
    public class CardServiceTests : IClassFixture<CardServiceFixtures>
    {
        public readonly CardServiceFixtures _cardServiceFixtures;

        public CardServiceTests(CardServiceFixtures cardServiceFixtures)
        {
            _cardServiceFixtures = cardServiceFixtures;
        }
        [Fact]
        public void ReturnShuffledCardsIfNoOfCardsIsNotNull()
        {
            var req = 3;

            var actualResult = _cardServiceFixtures._cardService.ShuffleCards(req);

            Assert.NotNull(actualResult);
        }

        [Fact]
        public void ReturnSortedCardsIfShuffledCardsAreNotNull()
        {
            var req = _cardServiceFixtures.ShuffleResponse();
            var expectedResponse = _cardServiceFixtures.SortedResponse();

            var actualResult = _cardServiceFixtures._cardService.SortedCards(req);

            Assert.Equal(expectedResponse, actualResult);
        }
    }
}