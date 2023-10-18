using System;

namespace uppgift_4_3
{
    class program
    {
        static void Main(string[] args)
        {
            int tal = 0;
            while (tal <= 100)
            {

                if (tal % 3 == 0 && tal % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    tal++;
                }
                else if (tal % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    tal++;
                }
                else if (tal % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    tal++;
                }
                else
                {
                    Console.WriteLine(tal);
                    tal++;
                }
            }
            Console.ReadKey();
        }
    }
}