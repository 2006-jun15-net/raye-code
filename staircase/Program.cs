using System;

namespace staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("  #");
            // Console.WriteLine(" ##");
            // Console.WriteLine("###");

            for(int row = 0; row < 8; row++)
            {
                for(int col = 0; col < 8; col++)
                {
                    if(col + row < 7)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.Write('\n');
            }
        }
    }
}
