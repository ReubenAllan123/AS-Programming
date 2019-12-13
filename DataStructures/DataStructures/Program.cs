using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures
{
    class Program
    {
        public const int limit = 2;
        public struct students
        {
            public string firstName;
            public string lastName;
            public string school;
            public int lastPercent;
            public char currentGrade;
        }
        static void Main(string[] args)
        {
            students[] people = new students[limit + 1];
            bool running = true;
            while (running == true)
            {
                switch (choice())
                {
                    case (1):
                        DataInput(ref people);
                        break;
                    case (2):
                        DataOutput(ref people);
                        break;
                    case (3):
                         SaveFile(people);
                        break;
                    case (4):
                        LoadFile(ref people);
                        break;
                    case (5):
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();                     
        }
        public static int choice()
        {
            Console.WriteLine("1. Input Data");
            Console.WriteLine("2. Output Data");
            Console.WriteLine("3. Save File");
            Console.WriteLine("4. Load File");
            Console.WriteLine("5. Exit Program");
            Console.Write("Choose an option: ");
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }
        public static void DataInput(ref students[] people)
        {
            bool temp = true;

            for (int i = 0; i < limit; i++)
            {
                Console.Write($"Enter first name {i + 1}: ");
                people[i].firstName = Console.ReadLine();

                Console.Write($"Enter last name {i + 1}: ");
                people[i].lastName = Console.ReadLine();

                Console.Write($"Enter school {i + 1}: ");
                people[i].school = Console.ReadLine();

                Console.Write($"Enter last test percentage {i + 1}: ");
                int.TryParse(Console.ReadLine(), out people[i].lastPercent);

                do
                {
                    Console.Write($"Enter current grade {i + 1}: ");
                    char.TryParse(Console.ReadLine().ToUpper(), out people[i].currentGrade);
                    if (people[i].currentGrade > 'E' && people[i].currentGrade != 'U') Console.WriteLine("Invalid grade");
                    else temp = false;
                } while (temp == true);

                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void DataOutput(ref students[] people)
        {
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"{i + 1}] {people[i].firstName}, {people[i].lastName}, {people[i].school}, {people[i].lastPercent}, {people[i].currentGrade}.");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void SaveFile(students[] people)
        {
            Console.Write("Enter a name for the file: ");
            string fileName = ($"{Console.ReadLine()}.dat");

            using (StreamWriter CurrentFile = new StreamWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int i = 0; i < limit; i++)
                {
                    CurrentFile.WriteLine(people[i].firstName);
                    CurrentFile.WriteLine(people[i].lastName);
                    CurrentFile.WriteLine(people[i].school);
                    CurrentFile.WriteLine(people[i].lastPercent);
                    CurrentFile.WriteLine(people[i].currentGrade);
                }
            }
            Console.WriteLine("Writing Complete.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void LoadFile(ref students[] people)
        {
            Console.Write("Enter a name for the file: ");
            string fileName = ($"{Console.ReadLine()}.dat");
            try
            {
                using (StreamReader CurrentFile = new StreamReader(File.Open(fileName, FileMode.Open)))
                {
                    for (int i = 0; i < limit; i++)
                    {
                        people[i].firstName = CurrentFile.ReadLine();
                        people[i].lastName = CurrentFile.ReadLine();
                        people[i].school = CurrentFile.ReadLine();
                        int.TryParse(CurrentFile.ReadLine(), out people[i].lastPercent);
                        char.TryParse(CurrentFile.ReadLine(), out people[i].currentGrade);
                    }
                }
                Console.WriteLine("Loading Complete.");
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}