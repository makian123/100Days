using System;

namespace Day067
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, k = 1;

            Console.Write("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter division: ");
            k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Result of division is {Division(n, k)}.");
        }

        static int Division(int num, int division)
        {
            int result = 0, numtemp = num;

            for(int i = 1; i <= num; ++i)
            {
                numtemp = num;
                for(int j = 0; j < division; ++j)
                {
                    numtemp -= i;
                }
                
                if(numtemp == 0)
                {
                    result = i;
                    break;
                }
                else if(numtemp < 0)
                {
                    result = i - 1;
                    break;
                }
            }

            return result;
        }
    }
}
