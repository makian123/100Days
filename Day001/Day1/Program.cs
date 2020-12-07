using System;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            int[] listOfNums = { 10, 15, 1, 7, 4, 7 };
            int k = 14;

            bool can = checkIfCan(listOfNums, k);

           if(can)
            {
                Console.WriteLine("Possible");
            }
           else
            {
                Console.WriteLine("Not possible");
            }
        }

        static bool checkIfCan(int[] list, int k)
        {
            for (int i = 0; i < list.Length - 1; ++i)
            {
                for (int j = i + 1; j < list.Length; ++j)
                {
                    if (list[i] + list[j] == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
