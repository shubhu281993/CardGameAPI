using CardGame.Business.Interface;
using CardGame.Common;

public class CardService : ICard
{
    public CardService()
    {

    }

    public List<string> ShuffleCards(int noOfcards)
    {
        var cards = new List<string>()
        {
            "4T","2T","ST","PT","RT",
            "2D","3D","4D","5D","6D","7D","8D","9D","10D","JD","QD","KD","AD",
            "2S","3S","4S","5S","6S","7S","8S","9S","10S","JS","QS","KS","AS",
            "2C","3C","4C","5C","6C","7C","8C","9C","10C","JC","QC","KC","AC",
            "2H","3H","4H","5H","6H","7H","8H","9H","10H","JH","QH","KH","AH",
        };
        return Common.PickRandom(cards, noOfcards);
    }

    public List<string> SortedCards(List<string> cards)
    {
        Dictionary<string,int> specialCards = new Dictionary<string,int>();
        Dictionary<string,int> diamondCards = new Dictionary<string, int>();
        Dictionary<string, int> spadeCards = new Dictionary<string, int>();
        Dictionary<string, int> clubCards = new Dictionary<string, int>();
        Dictionary<string, int> heartCards = new Dictionary<string, int>();
        List<string> allCards = new List<string>();
        foreach (var card in cards)
        {
            if (CardsMapping.SpecialCards.ContainsKey(card))
            {
                var x = CardsMapping.SpecialCards.Where(x=>x.Key == card).Select(x=>x).FirstOrDefault();
                specialCards.Add(x.Key,x.Value);
            }
            if (CardsMapping.DiamondCards.ContainsKey(card))
            {
                var x = CardsMapping.DiamondCards.Where(x => x.Key == card).Select(x => x).FirstOrDefault();
                diamondCards.Add(x.Key, x.Value);
            }
            if (CardsMapping.ClubCards.ContainsKey(card))
            {
                var x = CardsMapping.ClubCards.Where(x => x.Key == card).Select(x => x).FirstOrDefault();
                clubCards.Add(x.Key, x.Value);
            }
            if (CardsMapping.HeartCards.ContainsKey(card))
            {
                var x = CardsMapping.HeartCards.Where(x => x.Key == card).Select(x => x).FirstOrDefault();
                heartCards.Add(x.Key, x.Value);
            }
            if (CardsMapping.SpadeCards.ContainsKey(card))
            {
                var x = CardsMapping.SpadeCards.Where(x => x.Key == card).Select(x => x).FirstOrDefault();
                spadeCards.Add(x.Key, x.Value);
            }
        }

        specialCards= specialCards.OrderBy(z => z.Value).ToDictionary(y=>y.Key,y=>y.Value);
        diamondCards= diamondCards.OrderBy(z => z.Value).ToDictionary(y => y.Key, y => y.Value);
        spadeCards=spadeCards.OrderBy(z => z.Value).ToDictionary(y => y.Key, y => y.Value);
        clubCards=clubCards.OrderBy(z => z.Value).ToDictionary(y => y.Key, y => y.Value);
        heartCards=heartCards.OrderBy(z => z.Value).ToDictionary(y => y.Key, y => y.Value);

        foreach (var item in specialCards)
        {
            allCards.Add(item.Key);
        }
        foreach (var item in diamondCards)
        {
            allCards.Add(item.Key);
        }
        foreach (var item in spadeCards)
        {
            allCards.Add(item.Key);
        }
        foreach (var item in clubCards)
        {
            allCards.Add(item.Key);
        }
        foreach (var item in heartCards)
        {
            allCards.Add(item.Key);
        }

        return allCards;
    }
}
