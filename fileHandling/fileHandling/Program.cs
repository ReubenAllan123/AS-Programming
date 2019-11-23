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
            while (running == true)
            {
                switch (choice())
                {
                    case (1):
                        Console.WriteLine("*Load Questions*");
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
            }
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
        public static int choice()
        {
            int choice;     
            Console.WriteLine("1. Load questions");
            Console.WriteLine("2. Write new questions");
            Console.WriteLine("3. Take the quiz");
            Console.WriteLine("4. Exit program");
            Console.Write("Choose: ");
            int.TryParse(Console.ReadLine(), out choice);
            Console.WriteLine();
            return choice;
        }
        public static void loadQuestions()
        {
            string fileName;
            string[,] Questions = new string[2,10];
            Console.WriteLine("*The text file should list a question, then an answer on seperate lines.");
            Console.Write("Enter a file name of questions to load: ");
            fileName = Console.ReadLine();
            try
            {
               using (StreamReader CurrentFile = new StreamReader(fileName))
               {
                    for (int i = 0; i < 10; i++)
                    {
                        Questions[0, i] = CurrentFile.ReadLine();
                        Questions[1, i] = CurrentFile.ReadLine();
                    }
               }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            Console.WriteLine("Complete.");
        }
    }
}

