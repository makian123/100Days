using System;

namespace Day011
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 4, 17, 32, 15 };
            Console.Write("Nonswapped: ");
            for (int i = 0; i < values.Length; ++i)
            {
                Console.Write($"{values[i]} ");
            }
            Console.Write("\nSwapped: ");
            values = Swap(values);

            for (int i = 0; i < values.Length; ++i)
            {
                Console.Write($"{values[i]} ");
            }
        }

        static int[] Swap(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i += 2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }

            return array;
        }
    }
}
