using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject
{
    internal class Generic<T> where T : IComparable
    {
        public void FindMax(T first, T second, T third)
        {
            if ((first.CompareTo(second) >0)&&(first.CompareTo(third)>0))
            {
                Console.WriteLine(first+" is greates");
            }
            else if ((second.CompareTo(first)>0)&&(second.CompareTo(third)>0))
            {
                Console.WriteLine(second+" is greatest");
            }
            else if ((third.CompareTo(second)>0)&&(third.CompareTo(first)>0))
            {
                Console.WriteLine(third+" is greatest");
            }
            else
            {
                Console.WriteLine("All are equal");

            }
        }
    }
}
