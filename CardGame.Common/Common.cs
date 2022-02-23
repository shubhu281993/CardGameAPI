using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Common
{
    public static class Common
    {
        private static Random rng = new Random();
        
        public static List<string> PickRandom(this List<string> source, int count)
        {
            if (source.Any())
                return source.OrderBy(item=>rng.Next()).Take(count).ToList();
            return new List<string>();

        }
    }
}
