using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    internal class Bubsort<S> where S : IComparable
    {
        public static S Swap (ref S x , ref S y)
        {
            S temp = x;
            x = y;
            y = temp;

            return temp;
        }
        public static void BubbleSort(S[] arr)
        {
            if(arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1) Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
            }
            
        }
    }
}
