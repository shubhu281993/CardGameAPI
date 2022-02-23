using CardGame.Api.Tests.Fixtures;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CardGame.Api.Tests
{
    public class CardControllerTests : IClassFixture<CardControllerFixtures>
    {
        public readonly CardControllerFixtures _cardControllerFixtures;

        public CardControllerTests(CardControllerFixtures cardControllerFixtures)
        {
            _cardControllerFixtures = cardControllerFixtures;
        }
        [Fact]
        public void ReturnShuffledCardsIfNoOfCardsIsNotNull() 
        {
            var req = 2;
            var expectedResponse = _cardControllerFixtures.ShuffleResponse();

            _cardControllerFixtures._iCard.Setup(x=>x.ShuffleCards(req)).Returns(expectedResponse);

            var actualResult = _cardControllerFixtures._cardController.GetShuffledCards(req) as ObjectResult;

            Assert.IsType<OkObjectResult>(actualResult);
            Assert.Equal(expectedResponse, actualResult.Value);
        }

        [Fact]
        public void ReturnSortedCardsIfShuffledCardsAreNotNull()
        {
            var req = _cardControllerFixtures.ShuffleResponse();
            var expectedResponse = _cardControllerFixtures.SortedResponse();

            _cardControllerFixtures._iCard.Setup(x => x.SortedCards(req)).Returns(expectedResponse);

            var actualResult = _cardControllerFixtures._cardController.GetSortedCards(req) as ObjectResult;

            Assert.IsType<OkObjectResult>(actualResult);
            Assert.Equal(expectedResponse, actualResult.Value);
        }
    }
}