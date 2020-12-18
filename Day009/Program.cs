using System;
using System.Collections.Generic;

namespace Day009
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9] { 5, 1, 3, 5, 2, 3, 4, 1 };
            array = largestSubarray(array);

            for(int i = 0; i < array.Length; ++i)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static int[] largestSubarray(int[] array)
        {
            List<int> subArray = new List<int>();

            int[] maxSub = new int[] { 0 };

            for(int i = 0; i < array.Length; ++i)
            {
                subArray.Add(array[i]);
                for(int j = i; j < array.Length; ++j)
                {
                    if(j == i)
                    {
                        continue;
                    }
                    if(!isReocurring(array[j], subArray))
                    {
                        subArray.Add(array[j]);
                    }
                    
                }
                if(subArray.Count > maxSub.Length)
                {
                    maxSub = subArray.ToArray();
                }
                subArray.Clear();
            }

            return maxSub;
        }

        static bool isReocurring(int n, List<int> array)
        {
            for(int i = 0; i < array.Count; ++i)
            {
                if(n == array[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
