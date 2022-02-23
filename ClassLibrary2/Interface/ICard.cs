using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Business.Interface
{
    public interface ICard
    {
        List<string> SortedCards(List<string> cards);
        List<string> ShuffleCards(int noOfcards);
    }
}
