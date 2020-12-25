using System;
using System.Linq;

namespace Day017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers?\n> ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; ++i)
            {
                Console.Write($"Enter {i + 1}. number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"The greatest common divisor is: {FindGreatest(arr)}");
        }

        static int FindGreatest(int[] array)
        {
            int max = array.Min();
            int maxgc = 0;

            for(int i = 1; i <= max; ++i)
            {
                for(int j = 0; j < array.Length; ++j)
                {
                    if(array[j] % i != 0)
                    {
                        break;
                    }
                    else if(j == array.Length - 1)
                    {
                        maxgc = i;
                    }
                }
            }

            return maxgc;
        }
    }
}
