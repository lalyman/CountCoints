using System.Collections.Generic;
using System.Linq;

namespace CountCoins
{
    public class ChangeMaker
    {
        public static List<int> ImportantCoins = new List<int> {25, 10, 5, 1};

        public static int NumberOfWaysToMakeChange(int cents, List<int> importantCoins)
        {
            if (cents == 0)
            {
                return 1;
            }
            if (cents <= 0 || importantCoins.Count == 0)
            {
                return 0;
            }
            return NumberOfWaysToMakeChange(cents - importantCoins.First(), importantCoins) +
                   NumberOfWaysToMakeChange(cents, importantCoins.GetRange(1, importantCoins.Count - 1));
        }
    }
}