using System;

namespace CollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string selection;

            Console.WriteLine("Please enter number to perform Collatz Sequnce");

            selection = Console.ReadLine();

            number = int.Parse(selection);

            for(;number > 1;)
            {
                Console.WriteLine(number);

                if(number % 2 == 0)
                    number = number / 2;
                else
                    number = (number * 3) + 1;
            }
        }
    }
}
