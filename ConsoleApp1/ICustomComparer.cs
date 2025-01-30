using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ICustomComparer
    {
        bool Compare(int x, int y);

    }
    internal class Ascomparer : ICustomComparer
    {

        public bool Compare(int x, int y) => x > y;
       
    }
    internal class DescComparer : ICustomComparer {

        public bool Compare(int x, int y) => x < y;


    }
}
