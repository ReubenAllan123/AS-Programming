using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            switch (choice())
            {
                case (1):
                    loadQuestions();
                    break;
                case (2):
                    break;
                case (3):
                    break;
                case (4):
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
        public static int choice()
        {
            int choice;
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. Load questions");
            Console.WriteLine("2. Write new questions");
            Console.WriteLine("3. Take the quiz");
            Console.WriteLine("4. Exit program");
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }
        public static void loadQuestions()
        {
            string fileName;
            string[,] Questions;
            int Count = 0;

            Console.Write("Enter a file name of questions to load: ");
            fileName = Console.ReadLine();
            try
            {
               using (StreamReader CurrentFile = new StreamReader(fileName))
               {
                    //only 10 questions!!!!!!!!!!!!!!!!!
                    for (int i = 0; i < Questions.Length; i++)
                    {
                        Quesions[i] = CurrentFile.ReadLine();
                    }
               }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }

        }
    }
}

