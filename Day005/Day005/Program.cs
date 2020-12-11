using System;

namespace Day005
{
    class Program
    {
        static int repeating = 0;

        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string line = Console.ReadLine();

            Console.WriteLine($"The string is: {Unrepeatable(line)}");
        }

        static string Unrepeatable(string line)
        {
            char[] charLine = line.ToCharArray();

            while(!IsGood(charLine))
            {
                for(int i = 0; i < charLine.Length; ++i)
                {
                    if(charLine[i] != charLine[repeating])
                    {
                        (charLine[i], charLine[repeating]) = (charLine[repeating], charLine[i]);
                    }
                }
            }

            return new string(charLine);
        }

        static bool IsGood(char[] line)
        {
            for(int i = 0; i < line.Length - 1; i++)
            {
                if(line[i] == line[i + 1])
                {
                    repeating = i + 1;
                    return false;
                }
            }
            return true;
        }
    }
}
