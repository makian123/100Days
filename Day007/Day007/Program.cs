using System;

namespace Day007
{
    class Program
    {
        public class Point
        {
            public int p_val { get; set; }
            public int q_val { get; set; }

            public Point()
            {
                p_val = 0;
                q_val = 0;
            }
        }

        static void Main()
        {
            Console.Write("Enter array number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Point[] points = new Point[n];

            for(int i = 0; i < n; ++i)
            {
                points[i] = new Point();
                Console.Write($"Enter first value for the {i}. pair: ");
                points[i].p_val = Int32.Parse(Console.ReadLine());
                Console.Write($"Enter second value for the {i}. pair: ");
                points[i].q_val = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"There are {IntersectCheck(points)} intersections");
        }

        public static int IntersectCheck(Point[] arr)
        {
            int intersect = 0;

            for(int i = 0; i < arr.Length; ++i)
            {
                int p1 = arr[i].p_val;
                int q1 = arr[i].q_val;
                for(int j = i + 1; j < arr.Length; ++j)
                {
                    int fD = 0, sD = 0;
                    int p2 = arr[j].p_val;
                    int q2 = arr[j].q_val;

                    if(p1 >= 0 && q1 >= 0 || p1 >= 0 && q1 <= 0)
                    {
                        fD = q1 - p1;
                    }
                    else if(p1 <= 0 && q1 >= 0)
                    {
                        fD = p1 - q1;
                    }

                    if (p2 >= 0 && q2 >= 0 || p2 >= 0 && q2 <= 0)
                    {
                        sD = q2 - p2;
                    }
                    else if (p2 <= 0 && q2 >= 0)
                    {
                        sD = p2 - q2;
                    }

                    if(fD != sD)
                    {
                        intersect++;
                    }
                }
            }

            return intersect;
        }
    }
}
