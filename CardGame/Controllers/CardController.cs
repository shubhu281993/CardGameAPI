using CardGame.Business.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CardGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class CardController : Controller
    {
        readonly ICard _card;
        public CardController(ICard card)
        {
            _card = card;
        }

        [HttpPost]
        public IActionResult GetSortedCards([FromBody]List<string> cards)
        {
            return Ok(_card.SortedCards(cards));
        }

        [HttpGet]
        public IActionResult GetShuffledCards([FromQuery]int noOfcards)
        {
            return Ok(_card.ShuffleCards(noOfcards));
        }
    }
}
