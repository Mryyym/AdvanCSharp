using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Xml.Linq;
using System;

namespace FirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm  And implement the code of this optimized bubble sort algorithm


            ////ANSWER
            //usee flags or icomparable
            //IMPLEMENTATION

            /*
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Before:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            //Bubsort(arr);
            Bubsort<int>.BubbleSort(arr);

            Console.WriteLine("After:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            */
            #endregion
            
            
            #region 2-Create a generic class named Range<T> where T represents the type of values.
            try
            {

                Range<int> intRange = new Range<int>(10, 20);
                Console.WriteLine($"Is 15 in range: {intRange.IsInRange(15)}"); 
                Console.WriteLine($"Is 25 in range: {intRange.IsInRange(25)}"); 
                Console.WriteLine($"Length of range: {intRange.Length()}"); 

                Range<double> doubleRange = new Range<double>(5.5, 10.5);
                Console.WriteLine($"Is 7.5 in range: {doubleRange.IsInRange(7.5)}"); 
                Console.WriteLine($"Length of range: {doubleRange.Length()}"); 

                // Range<string> stringRange = new Range<string>("a", "z");
                // Console.WriteLine(stringRange.Length());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


            #endregion



        }
    }
}
