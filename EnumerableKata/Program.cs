using System;
using System.Linq;

namespace EnumerableKata
{
    class KataFun
    {
        public static int KataInt(int value)
        {
            return Enumerable.Range(0, value)
                             .Where(x => x % 3 == 0 || x % 5 == 0)
                             .Sum();
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            KataFun.KataInt(10);
        }
    }
}
