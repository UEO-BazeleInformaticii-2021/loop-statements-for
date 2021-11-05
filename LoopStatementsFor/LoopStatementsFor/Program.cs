using System;

namespace LoopStatementsFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a text=");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();
        }
    }
}
