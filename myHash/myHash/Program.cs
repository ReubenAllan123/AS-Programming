using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHash
{
    class Program
    {
        public struct student
        {
            public string examNo;
            public string surname;
            public string firstname;
            public string house;
            public string tutor;
        }

        static void Main(string[] args)
        {
            student[] hashTable = new student[100];
            bool running = true;

            while (running == true)
            {
                switch (choice())
                {
                    case (1):
                        student aStudent = EnterDetails();
                        int index = HashFunction(aStudent.examNo);
                        AddRecord(aStudent, ref hashTable);
                        break;
                    case (2):
                        DisplayRecord(hashTable);
                        break;
                    case (3):
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
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. Add record");
            Console.WriteLine("2. Display record");
            Console.WriteLine("3. Exit program");
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }

        static int HashFunction(string key)
        {
            int index;

            int a = int.Parse(key[0].ToString());
            int b = int.Parse(key[1].ToString());
            int c = int.Parse(key[2].ToString());
            int d = int.Parse(key[3].ToString());

            index = ((a * 1 + b * 2 + c * 3 + d * 4) % 50) * 2;

            return index;
        }

        static void AddRecord(student newRecord, ref student[] hashtable)
        {
            int key = HashFunction(newRecord.examNo);
            if (hashtable[key].examNo == null)
            {
                hashtable[key] = newRecord;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static student GetRecord(string examNo, student[] hashTable)
        {
            int key = HashFunction(examNo);
            student oldRecord = hashTable[key];
            return oldRecord;
        }

        static student EnterDetails()
        {
            student newRecord = new student();
            Console.Clear();

            Console.WriteLine("*ADD A RECORD*");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.Write("Enter exam number: ");
            newRecord.examNo = Console.ReadLine();
            while (newRecord.examNo.Length != 4)
            {
                Console.Beep();
                Console.WriteLine("Enter a 4 digit number");
                Console.WriteLine("Please enter student details");
                newRecord.examNo = Console.ReadLine();
            }
            Console.Write("Enter firstname:   ");
            newRecord.firstname = Console.ReadLine();
            Console.Write("Enter surname:     ");
            newRecord.surname = Console.ReadLine();
            Console.Write("Enter house:       ");
            newRecord.house = Console.ReadLine();
            Console.Write("Enter tutor:       ");
            newRecord.tutor = Console.ReadLine();

            return newRecord;
        }

        static void DisplayRecord(student[] hashTable)
        {
            student oldRecord;
            string examNo;
            Console.Clear();

            Console.WriteLine("*DISPLAY A RECORD*");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine("Enter the exam number: ");
            examNo = Console.ReadLine();

            while (examNo.Length != 4)
            {
                Console.Beep();
                Console.WriteLine("Enter a 4 digit number");
                Console.Write("Please enter student exam number: ");
                examNo = Console.ReadLine();
            }

            oldRecord = GetRecord(examNo, hashTable);

            Console.WriteLine($"Exam number: {oldRecord.examNo}");
            Console.WriteLine($"Firstname:   {oldRecord.firstname}");
            Console.WriteLine($"Surname:     {oldRecord.surname}");
            Console.WriteLine($"House:       {oldRecord.house}");
            Console.WriteLine($"Tutor group: {oldRecord.tutor}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}