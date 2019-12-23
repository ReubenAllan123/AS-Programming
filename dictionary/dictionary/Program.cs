using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string sentance;

            try
            {
                using (StreamReader CurrentFile = new StreamReader("input.txt"))
                {
                    do
                    {
                        sentance = CurrentFile.ReadLine();
                        CountWords(sentance, dictionary);
                    } while (CurrentFile.Peek() != -1);

                    OutputWords(dictionary);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found");
                throw;
            }
            Console.ReadKey();
        }
        static void CountWords(string sentance, Dictionary<string, int> dictionary)
        {
            string[] seperators = { ". ", ", ", " ", "! ", "? ", ": ", ")", "(" };
            string[] wordArray = sentance.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in wordArray)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] = dictionary[word] + 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }
        }
        static void OutputWords(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> definition in dictionary.OrderByDescending(key => key.Value))
            {
                Console.WriteLine($"{definition.Value},  {definition.Key}");
            }
        }
    }
}

