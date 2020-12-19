using System;

namespace Day004
{
    class Program
    {
        private class Couple
        {
            public int firstPerson { get; set; }
            public int secondPerson { get; set; }

            public Couple()
            {
                this.firstPerson = 0;
                this.secondPerson = 0;
            }
        }

        static void Main()
        {
            int n = 4;
            Couple[] couples = new Couple[n];

            //Initialize seats array
            for(int i = 0; i < n; ++i)
            {
                couples[i] = new Couple();
            }

            for(int i = 0; i < n; ++i)
            {
                Console.Write("Input the first member for pair {0}: ", i + 1);
                couples[i].firstPerson = Int32.Parse(Console.ReadLine());
                Console.Write("Input the second member for pair {0}: ", i + 1);
                couples[i].secondPerson = Int32.Parse(Console.ReadLine());

                //Make sure first person is smaller
                if(couples[i].firstPerson > couples[i].secondPerson)
                {
                    (couples[i].firstPerson, couples[i].secondPerson) = (couples[i].secondPerson, couples[i].firstPerson);
                }
            }

            int[] seats = new int[n*2];

            //Fill in the seats in order
            for(int i = 0; i < n; ++i)
            {
                seats[i * 2] = new int();
                seats[i * 2 + 1] = new int();
                seats[i * 2] = couples[i].firstPerson;
                seats[i * 2 + 1] = couples[i].secondPerson;
            }

            seats = shuffleArray(seats);

            
        }

        public static int[] shuffleArray(int[] array)
        {
            var random = new Random();

            for(int i = array.Length; i > 1; --i)
            {
                int j = random.Next(i);

                int tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }

            return array;
        }
    }
}
