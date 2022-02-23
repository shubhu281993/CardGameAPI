﻿public static class CardsMapping
{
    private static readonly Dictionary<string, string> SpecialCards
    = new Dictionary<string, string>
{
    { "4T", "1" },
    { "2T", "2" },
    { "ST", "3" },
    { "PT", "4" },
    { "RT", "5" }
};
    private static readonly Dictionary<string, string> DiamondCards
    = new Dictionary<string, string>
{
    { "2D", "1" },
    { "3D", "2" },
    { "4D", "3" },
    { "5D", "4" },
    { "6D", "5" },
    { "7D", "6" },
    { "8D", "7" },
    { "9D", "8" },
    { "10D", "9" },
    { "JD", "10" },
    { "QD", "11" },
    { "KD", "12" },
    { "AD", "13" }
};
    private static readonly Dictionary<string, string> SpadeCards
    = new Dictionary<string, string>
{
    { "2S", "1" },
    { "3S", "2" },
    { "4S", "3" },
    { "5S", "4" },
    { "6S", "5" },
    { "7S", "6" },
    { "8S", "7" },
    { "9S", "8" },
    { "10S", "9" },
    { "JS", "10" },
    { "QS", "11" },
    { "KS", "12" },
    { "AS", "13" }
};
    private static readonly Dictionary<string, string> ClubCards
    = new Dictionary<string, string>
{
    { "2C", "1" },
    { "3C", "2" },
    { "4C", "3" },
    { "5C", "4" },
    { "6C", "5" },
    { "7C", "6" },
    { "8C", "7" },
    { "9C", "8" },
    { "10C", "9" },
    { "JC", "10" },
    { "QC", "11" },
    { "KC", "12" },
    { "AC", "13" }
};
    private static readonly Dictionary<string, string> HeartCards
    = new Dictionary<string, string>
{
    { "2H", "1" },
    { "3H", "2" },
    { "4H", "3" },
    { "5H", "4" },
    { "6H", "5" },
    { "7H", "6" },
    { "8H", "7" },
    { "9H", "8" },
    { "10H", "9" },
    { "JH", "10" },
    { "QH", "11" },
    { "KH", "12" },
    { "AH", "13" }
};
}