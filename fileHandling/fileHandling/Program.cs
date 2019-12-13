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
            string[,] Questions = new string[2, 10];
            int score = 0;
            bool running = true;
            while (running == true)
            {
                switch (choice(Questions))
                {
                    case (1):
                        Console.WriteLine("*Load Questions*");
                        loadQuestions(ref Questions);
                        break;
                    case (2):
                        Console.WriteLine("*Write Questions*");
                        writeQuestions(ref Questions);
                        break;
                    case (3):
                        GetName(out string userName);
                        AskQuestion(Questions, ref score);
                        Console.WriteLine(ScoreReport(userName, score));
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
        public static int choice(string[,] Questions)
        {
            int choice;
            Console.WriteLine("1. Load questions");
            Console.WriteLine("2. Write new questions");
            if (Questions[0, 0] == null)
            {
                Console.WriteLine("3. Exit program");
            }
            else
            {
                Console.WriteLine("3. Take the quiz");
                Console.WriteLine("4. Exit program");
            }
            Console.Write("Choice: ");
            int.TryParse(Console.ReadLine(), out choice);
            Console.WriteLine();
            return choice;
        }
        public static void loadQuestions(ref string[,] Questions)
        {
            Console.WriteLine("*The text file should list a question, then an answer on seperate lines.");
            Console.Write("Enter a file name of questions to load: ");
            string fileName = Console.ReadLine();
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
        public static void writeQuestions(ref string[,] Questions)
        {
            Console.Write("Enter a name for the file: ");
            string fileName = Console.ReadLine();
            using (StreamWriter CurrentFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Question {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.Write($"Answer {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine().ToLower());
                }
            }
            Console.WriteLine("Writing Complete.");
        }
        private static void GetName(out string userName)
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome to the quiz, {userName}!");
            Console.WriteLine();
        }
        private static void AskQuestion(string[,] Questions, ref int score)
        {
            string userAnswer;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Questions[0, i]);
                userAnswer = Console.ReadLine().ToLower();
                if (userAnswer == Questions[1, i])
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
        }
        private static string ScoreReport(string userName, int score)
        {
            string report = $"{userName}'s score is {score}! ";
            if (score >= (10 * 0.8))
            {
                report = report + "Well done!";
            }
            else if (score >= (10 * 0.5))
            {
                report = report + "Better luck next time!";
            }
            else
            {
                report = report + "Failure.";
            }
            return report;
        }
    }
}