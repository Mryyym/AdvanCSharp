using System;
using System.Collections;
using SecondAssignment;

namespace SecondAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //try
            //{
            //    string[] firstLine = Console.ReadLine().Split(' ');
            //    int n = int.Parse(firstLine[0]);
            //    int q = int.Parse(firstLine[1]);

            //    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //    for (int i = 0; i < q; i++)
            //    {
            //        int query = int.Parse(Console.ReadLine());
            //        int result = _ِassignmentClass.CountGreater(array, query);
            //        Console.WriteLine(result);
            //    }
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}


            #endregion
            #region 2- Given a number N and an array of N numbers. Determine if it's palindrome or not

            //try
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //    if (_ِassignmentClass.IsPalindrome(array))
            //    {
            //        Console.WriteLine("YES");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //    }
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}

            #endregion
            #region 3-Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Queue<int> queue = new Queue<int>(array);
            //Queue<int> reversedQueue = _ِassignmentClass.ReverseQuee(queue);
            //Console.WriteLine("Reversed Queue: " + string.Join(" ", reversedQueue));

            #endregion
            #region 4- Given a Stack, implement a function to check if a string of parentheses is balanced using a stack

            //try
            //{
            //    Console.WriteLine("Enter a string of parentheses:");
            //    string parenthesesInput = Console.ReadLine();
            //    if (_ِassignmentClass.IsBalancedParentheses(parenthesesInput))
            //    {
            //        Console.WriteLine("Balanced");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Balanced");
            //    }
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}



            #endregion
            #region 5- Given an array, implement a function to remove duplicate elements from an array.

            //try
            //{
            //    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    int[] uniqueArray = _ِassignmentClass.RemoveDuplicates(array);
            //    Console.WriteLine("Array without duplicates: " + string.Join(" ", uniqueArray));
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}

            #endregion
            #region 6- Given an array list , implement a function to remove all odd numbers from it.

            //try
            //{
            //    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    List<int> list = array.ToList();
            //    List<int> evenList = _ِassignmentClass.RemoveOddNumbers(list);
            //    Console.WriteLine("List without odd numbers: " + string.Join(" ", evenList));

            //}
            //catch (Exception x )
            //{

            //    Console.WriteLine(x.Message);
            //}

            #endregion
            #region 7- Implement a queue that can hold different data types. 

            //try
            //{
            //    Queue<object> mixedQueue = new Queue<object>();
            //    mixedQueue.Enqueue(1);
            //    mixedQueue.Enqueue("Apple");
            //    mixedQueue.Enqueue(5.28);
            //    Console.WriteLine("Queue with different data types: " + string.Join(", ", mixedQueue));
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}

            #endregion
            #region 8- Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target 

            try
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Stack<int> stack = new Stack<int>(array);
                Console.WriteLine("Enter the target to search in the stack:");
                int target = int.Parse(Console.ReadLine());
                _ِassignmentClass.PushIntegers(stack, target);
            }
            catch (Exception x)
            {

                Console.WriteLine(x.Message);
            }

            #endregion
            #region 9- Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //try
            //{
            //    Console.WriteLine("Enter the size of first array:");
            //    int size1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the first array:");
            //    List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //    Console.WriteLine("Enter the size of second array:");
            //    int size2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the second array:");
            //    List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //    List<int> intersection = _ِassignmentClass.FindIntersection(list1, list2);
            //    Console.WriteLine("Intersection: " + string.Join(" ", intersection));
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}

            #endregion
            #region 10- Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //try
            //{
            //    ArrayList arr = new ArrayList() { 1, 2, 3, 7, 5 };
            //    int target = 12;

            //    ArrayList result =_ِassignmentClass.FindWithSum(arr, target);

            //    if (result != null)
            //    {
            //        Console.WriteLine("Sublist found: [" + string.Join(", ", result.Cast<int>()) + "]");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No sublist found.");
            //    }
            //}
            //catch (Exception x)
            //{

            //    Console.WriteLine(x.Message);
            //}

            #endregion
            #region 11- Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            try
            {
                Queue<int> q = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
                int k = 3;
                Queue<int> result = _ِassignmentClass.ReverseFirstKElements(q, k);

                Console.WriteLine("Reversed queue: " + string.Join(", ", result));
            }
            catch (Exception x)
            {

                Console.WriteLine(x.Message);
            }

            #endregion



        }
    }
}
