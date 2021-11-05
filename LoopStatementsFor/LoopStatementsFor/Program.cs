using System;
using System.Text;

namespace LoopStatementsFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a text=");
            string text = Console.ReadLine();

            int numberOfDigits = 0;
            StringBuilder textNormal = new StringBuilder();
            StringBuilder textReversed = new StringBuilder();

            for (int indexFromStart = 0, indexFromEnd = text.Length - 1; 
                 indexFromStart < text.Length && indexFromEnd >= 0; 
                 indexFromStart++, indexFromEnd--)
            {
                textNormal.Append(text[indexFromStart]);
                textReversed.Append(text[indexFromEnd]);

                if (char.IsDigit(text[indexFromStart]))
                {
                    numberOfDigits++;
                }
            }

            Console.WriteLine(textNormal.ToString());
            Console.WriteLine(textReversed.ToString());
            Console.WriteLine($"Text has {numberOfDigits} digits");
        }
    }
}
