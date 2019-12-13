using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StructuredQuiz
{
    class Program
    {
        public struct QandA
        {
            public string question;
            public string answer1;
            public string answer2;
            public string answer3;
            public string correctAnswer;
        }
        static void Main(string[] args)
        {
            QandA[] qandAs = new QandA[10];
            int[] numbers = new int[10];
            int[] threeNum = new int[3];
            int score = 0;
            bool running = true;

            Console.WriteLine("All Brand New and Super Improved Quiz!");
            Console.WriteLine("**************************************");

            while (running == true)
            {
                switch (Choice())
                {
                    case (1):
                        Console.WriteLine("*Load Questions*");
                        LoadQuestions(ref qandAs);
                        break;
                    case (2):
                        Console.WriteLine("*Write Questions*");
                        WriteQuestions();
                        break;
                    case (3):
                        GetName(out string userName);
                        RandomNumberSequence(ref numbers);
                        AskQuestion(qandAs, ref score, numbers, ref threeNum);
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
        public static int Choice()
        {
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. Load questions");
            Console.WriteLine("2. Write new questions");
            Console.WriteLine("3. Take the quiz");
            Console.WriteLine("4. Exit program");
            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }
        public static void LoadQuestions(ref QandA[] qandAs)
        {
            Console.WriteLine("*The text file should list a question, 3 options, and a correct answer.");
            Console.Write("Enter a file name of questions to load: ");
            string fileName = Console.ReadLine();
            try
            {
                using (StreamReader CurrentFile = new StreamReader(fileName))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        qandAs[i].question = CurrentFile.ReadLine();
                        qandAs[i].answer1 = CurrentFile.ReadLine();
                        qandAs[i].answer2 = CurrentFile.ReadLine();
                        qandAs[i].answer3 = CurrentFile.ReadLine();
                        qandAs[i].correctAnswer = CurrentFile.ReadLine();
                    }
                }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            Console.WriteLine("Loading Complete.");
        }
        public static void WriteQuestions()
        {
            Console.Write("Enter a file name to write: ");
            string fileName = Console.ReadLine();
            using (StreamWriter CurrentFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Enter Question {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.Write($"Enter option 1 for {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.Write($"Enter option 2 for {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.Write($"Enter option 3 for {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.Write($"Enter the correct Answer for {i + 1}: ");
                    CurrentFile.WriteLine(Console.ReadLine());
                    Console.WriteLine();
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
        private static void RandomNumberSequence(ref int[] numbers)
        {
            Random RandomNumberGenerator = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                int j = RandomNumberGenerator.Next(9);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
        private static void RandomOptionSequence(ref int[] threeNum)
        {
            Random RandomNumberGenerator = new Random();
            for (int i = 0; i < 3; i++)
            {
                threeNum[i] = i;
            }
            for (int i = 0; i < 3; i++)
            {
                int j = RandomNumberGenerator.Next(2);
                int temp = threeNum[i];
                threeNum[i] = threeNum[j];
                threeNum[j] = temp;
            }
        }
        private static void AskQuestion(QandA[] qandAs, ref int score, int[] numbers, ref int[] threeNum)
        {
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{qandAs[numbers[i]].question}");
                RandomOptionSequence(ref threeNum);
                while (count < 3)
                {
                    switch (threeNum[count])
                    {
                        case (0):
                            Console.WriteLine($"{qandAs[numbers[i]].answer1}");            
                            break;
                        case (1):
                            Console.WriteLine($"{qandAs[numbers[i]].answer2}");
                            break;
                        case (2):
                            Console.WriteLine($"{qandAs[numbers[i]].answer3}");
                            break;
                    }
                    count++;
                }                                
                Console.WriteLine();
                Console.Write("Type your answer: ");
                if (Console.ReadLine() == qandAs[numbers[i]].correctAnswer)
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
                report += "Well done!";
            }
            else if (score >= (10 * 0.5))
            {
                report += "Better luck next time!";
            }
            else
            {
                report += "Failure.";
            }
            return report;
        }
    }
}