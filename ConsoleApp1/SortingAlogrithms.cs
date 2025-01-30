using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate TResult CustomFunc<in T1,in T2,out TResult>(T1 arg01, T2 arg02);
    internal class SortingAlogrithms<T>
    {
        public static void BubbleSort(T[]elements,CustomFunc<T,T,bool>Func )
        {
            if(elements is null)
            
                return;
            //1 4 8 4 9 0
            for(int i=0;i<elements.Length; i++)
            {
                for(int j=0;j<elements.Length-1-i;j++)
                {
                    //if (Numbers[j]<Numbers[j+1])
                    //{
                    if (Func.Invoke(elements[j], elements[j+1]))
                        Swap(ref elements[j], ref elements[j+1]);
                   // }
                }
            }
        }
        public static void Swap(ref T  x,ref  T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
