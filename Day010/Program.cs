using System;

namespace Day010
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6]{ 6, 5, 4, 3, 2, 1};

            for(int i = 0; i < array.Length; ++i)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
