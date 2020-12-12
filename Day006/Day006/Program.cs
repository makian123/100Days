using System;

namespace Day006
{
    class Program
    {
        class Interval
        {
            public int startPos { get; set; }
            public int endPos { get; set; }

            public Interval()
            {
                startPos = 0;
                endPos = 0;
            }

            public Interval(int a, int b)
            {
                startPos = a;
                endPos = b;
            }

            public Interval(Interval interval)
            {
                this.startPos = interval.startPos;
                this.endPos = interval.endPos;
            }
        }

        static void Main(string[] args)
        {
            //Initialise values
            Console.Write("Type how many intervals: ");
            int n = int.Parse(Console.ReadLine());

            Interval[] intervals = new Interval[n];

            //Input end and start values of interval
            for (int i = 0; i < intervals.Length; ++i)
            {
                intervals[i] = new Interval();

                Console.Write($"Type starting value of {i + 1}. interval: ");
                intervals[i].startPos = int.Parse(Console.ReadLine());
                Console.Write($"Type ending value of {i + 1}. interval: ");
                intervals[i].endPos = int.Parse(Console.ReadLine());

                //Check if start pos smaller than end pos, if is switch em
                if (intervals[i].startPos < intervals[i].endPos)
                {
                    (intervals[i].startPos, intervals[i].endPos) = (intervals[i].endPos, intervals[i].startPos);
                }

            }

            //Sort the intervals based on their start pos
            for (int i = 0; i < intervals.Length - 1; ++i)
            {
                if (intervals[i].startPos > intervals[i + 1].startPos)
                {
                    (intervals[i], intervals[i + 1]) = (intervals[i + 1], intervals[i]);
                }
            }

            //Initialize vars for the removing
            int j = 0;
            int removedIntervals = 0;

            for (int i = 1; i < n; ++i)
            {
                if (intervals[j].endPos > intervals[i].startPos)
                {
                    ++removedIntervals;
                }
                else
                {
                    j = i;
                }
            }

            Console.WriteLine($"{removedIntervals} was the minimum intervals deleted to work");
            Console.ReadKey();
        }
    }
}
