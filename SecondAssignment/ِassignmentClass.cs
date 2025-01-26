using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    public static class _ِassignmentClass
    {
        //1
        public static int CountGreater<T>(T[] array, T x) where T : IComparable<T>
        {
            return array.Count(item => item.CompareTo(x) > 0);
        }

        //2
        public static bool IsPalindrome<T>(T[] array) where T : IEquatable<T>
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (!array[i].Equals(array[length - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }

        //3
        public static Queue<T> ReverseQuee<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        //4
        public static bool IsBalancedParentheses(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        //5
        public static T[] RemoveDuplicates<T>(T[] array)
        {
            return array.Distinct().ToArray();
        }

        //6
        public static List<int> RemoveOddNumbers(List<int> list)
        {
            return list.Where(x => x % 2 == 0).ToList();
        }

        //8
        public static void PushIntegers(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;

            foreach (var item in stack)
            {
                count++;
                if (item == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }

        //9
        public static List<int> FindIntersection(List<int> list1, List<int> list2)
        {
            Dictionary<int, int> elementCounts = new Dictionary<int, int>();

            foreach (var num in list1)
            {
                if (elementCounts.ContainsKey(num))
                {
                    elementCounts[num]++;
                }
                else
                {
                    elementCounts[num] = 1;
                }
            }

            List<int> intersection = new List<int>();

            foreach (var num in list2)
            {
                if (elementCounts.ContainsKey(num) && elementCounts[num] > 0)
                {
                    intersection.Add(num);
                    elementCounts[num]--;
                }
            }

            return intersection;
        }

        //10
        public static ArrayList FindWithSum(ArrayList arr, int target)
        {
            int start = 0;
            int currentSum = 0;

            for (int end = 0; end < arr.Count; end++)
            {
                currentSum += (int)arr[end];

                while (currentSum > target && start <= end)
                {
                    currentSum -= (int)arr[start];
                    start++;
                }

                if (currentSum == target)
                {
                    ArrayList sublist = new ArrayList();
                    for (int i = start; i <= end; i++)
                    {
                        sublist.Add(arr[i]);
                    }
                    return sublist;
                }
            }

            return null;
        }

        //11
        public static Queue<int> ReverseFirstKElements(Queue<int> q, int k)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(q.Dequeue());
            }

            while (stack.Count > 0)
            {
                q.Enqueue(stack.Pop());
            }

            int remaining = q.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                q.Enqueue(q.Dequeue());
            }

            return q;
        }
    }
}
