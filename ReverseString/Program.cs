using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter string for reversal: ");
            string userEntry = new string(Console.ReadLine());
            Console.Write('\n');

            for(int pointer = 0; pointer < userEntry.Length; pointer++)
            {
                Console.Write(userEntry.Substring(userEntry.Length-pointer-1, 1));
            }
        }
    }
}