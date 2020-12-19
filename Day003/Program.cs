using System;

namespace Day003
{
    class Program
    {
        public class Numbers
        {
            private bool marked;
            private int value = 0;

            public void setMark(bool tf)
            {
                marked = tf;
            }
            public void setValue(int i)
            {
                value = i;
            }

            public bool getMark()
            {
                return marked;
            }
            public int getValue()
            {
                return value;
            }
        }

        static void Main()
        {
            int maxValue = 100;
            Numbers[] nums = new Numbers[maxValue];

            //populate nums
            for(int i = 0; i < maxValue; ++i)
            {
                nums[i] = new Numbers();
                nums[i].setValue(i + 1);
            }

            for(int i = 1; i < maxValue; ++i)
            {
                if(!isPrime(i))
                {
                    for(int j = 2 * i; j <= maxValue; j += i)
                    {
                        nums[j - 1].setMark(true);
                    }
                }
            }

            Console.Write("Prime numbers are: ");
            for (int i = 0; i < maxValue; ++i)
            {
                if(nums[i].getMark() == false)
                {
                    Console.Write("{0}, ", nums[i].getValue());
                }
            }
        }

        static bool isPrime(int value)
        {
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
