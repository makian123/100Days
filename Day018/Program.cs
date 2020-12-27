using System;

namespace Day018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 2, 2, 6, 6, 6, 6 };

            int[] numbers = Highest(array);

            if(numbers[1] > MathF.Floor(array.Length / 2f))
            {
                Console.WriteLine($"Most numbers are: {numbers[0]}");
            }
        }

        static int[] Highest(int[] arr)
        {
            int num = 0, tempmax = 0, maxIndex = 0;

            for(int i = 0; i < arr.Length; ++i)
            {
                tempmax = 0;
                for(int j = i; j < arr.Length; ++j)
                {
                    if(arr[j] == arr[i])
                    {
                        tempmax++;
                    }
                }

                if(tempmax > num)
                {
                    num = tempmax;
                    maxIndex = i;
                }
            }

            return new int[2] { arr[maxIndex], num };
        }
    }
}
