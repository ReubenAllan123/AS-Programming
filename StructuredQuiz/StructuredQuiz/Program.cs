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
            int score = 0;

            loadQuestions(ref qandAs);
            GetName(out string userName);
            RandomNumberSequence(ref numbers);
            AskQuestion(qandAs, ref score, numbers);
            Console.WriteLine(ScoreReport(userName, score));
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
        public static void loadQuestions(ref QandA[] qandAs)
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
        private static void AskQuestion(QandA[] qandAs, ref int score, int[] numbers)
        {
            string userAnswer;
            int choice;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"{qandAs[numbers[i]].question}");
                Console.WriteLine($"1) {qandAs[numbers[i]].answer1}");
                Console.WriteLine($"2) {qandAs[numbers[i]].answer2}");
                Console.WriteLine($"3) {qandAs[numbers[i]].answer3}");
                Console.WriteLine();
                Console.WriteLine("Choose 1, 2, or 3: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case (1):
                        userAnswer = qandAs[numbers[i]].answer1;
                        break;
                    case (2):
                        userAnswer = qandAs[numbers[i]].answer2;
                        break;
                    case (3):
                        userAnswer = qandAs[numbers[i]].answer3;
                        break;
                    default:
                        userAnswer = "";
                        break;
                }

                if (userAnswer == qandAs[numbers[i]].correctAnswer)
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