using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SortingTypes
    {
        public static bool Grt(int x, int y) => x > y;
        public static bool less(int x, int y) => x < y;
        public static bool Grt(String x, String  y) => x .CompareTo( y)==-1;
        public static bool less(String x, String y) => x.CompareTo(y) ==1;

    }

}
