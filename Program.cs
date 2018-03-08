using System;

namespace project_euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var correctNum = 0;
            for (var i = 0; i < 1000000000; i++)
            {
                if (EvenlyDivisible(i + 1))
                {
                    correctNum = i + 1;
                    break;
                }
            }
            Console.WriteLine("The right numer is " + correctNum);
        }
    
        public static bool EvenlyDivisible(int num)
        {
            bool divisible = false;
            for (var i = 0; i <= 20; i++)
            {
                var x = i + 1;
                if ((i == 1) && (num % x == 0))
                {
                    divisible = true;
                }

                if (num % x != 0)
                {
                    divisible = false;
                }
            }
            return divisible;
        }

    }
}
