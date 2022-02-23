using CardGame.Business.Interface;
using CardGame.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Api.Tests.Fixtures
{
    public class CardControllerFixtures : IDisposable
    {
        public readonly CardController _cardController;
        public readonly Mock<ICard> _iCard;

        public CardControllerFixtures()
        {
            _iCard = new Mock<ICard>(); 

            _cardController = new CardController(_iCard.Object);
        }
        
        public List<string> ShuffleRequest()
        {
            return new List<string>()
            {

            };
        }
        public List<string> ShuffleResponse()
        {
            return new List<string>()
            {
                "5D",
                "7C",
                "4T"
            };
        }
        public List<string> SortedResponse()
        {
            return new List<string>()
            {
                "4T",
                "5D",
                "7C"
            };
        }
        public void Dispose()
        {
        }
    }
}
