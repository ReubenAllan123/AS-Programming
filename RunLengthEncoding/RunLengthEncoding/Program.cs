using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Length_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string source;
            string compressed = "";
            int sourceLength;
            int timesUsed = 0;
            char character;

            Console.Write("Input source text: ");
            source = Console.ReadLine() + " ";
            sourceLength = source.Length;

            character = source[0];
            for (int i = 0; i < sourceLength; i++)
            {
                if (character == source[i])
                {
                    character = source[i];
                    timesUsed++;
                }
                else
                {
                    compressed = compressed + character;
                    compressed = compressed + timesUsed + “ “;

                    character = source[i];
                    timesUsed = 1;
                }
            }

            Console.WriteLine(compressed);
            Console.ReadKey();
        }
    }
}
