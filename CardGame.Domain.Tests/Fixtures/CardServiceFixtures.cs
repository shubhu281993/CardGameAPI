using CardGame.Business.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Tests.Fixtures
{
    public class CardServiceFixtures
    {
        public readonly CardService _cardService;

        public CardServiceFixtures()
        {
            _cardService = new CardService();
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
