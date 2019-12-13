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
            student aStudent = EnterDetails();
            int index = HashFunction(aStudent.examNo);
            AddRecord(aStudent, ref hashTable);
            Console.ReadLine();
            DisplayRecord();
        }

        static int HashFunction(string key)
        {
            int index;

            int.TryParse(key[0], out int a);
            int.TryParse(key[1], out int b);
            int.TryParse(key[2], out int c);
            int.TryParse(key[3], out int d);

            index = ((a * 1 + b * 2 + c * 3 + d * 4) % 50) * 2;

            return index;
        }
        static void AddRecord(student newRecord, student[] hashtable)
        {
            int key = HashFunction(newRecord.examNo);
            if(hashtable[key].examNo == null)
            {
                hashtable[key] = newRecord;
            }
        }
        static student GetRecord(string examNo, student[] hashTable)
        {
            int key = HashFunction(examNo);
            student oldRecord = hashTable[key];
            return oldRecord;
        }
        static void EnterDetails()
        {
            student newRecord = new student();
            Console.Clear();
            Console.WriteLine("Enter student details");
            newRecord.examNo = Console.ReadLine();
            while (newRecord.examNo.Length != 4)
            {
                Console.Beep();
                Console.WriteLine("Enter a 4 digit number");
                Console.WriteLine("Please enter student details");
                newRecord.examNo = Console.ReadLine();
            }
            Console.Write("Exam number: ");
            newRecord.examNo = Console.ReadLine();
            Console.Write("First name: ");
            newRecord.firstname = Console.ReadLine();
            Console.Write("Surname: ");
            newRecord.surname = Console.ReadLine();
            Console.Write("House: ");
            newRecord.house = Console.ReadLine();
            Console.Write("Tutor: ");
            newRecord.tutor = Console.ReadLine();

            return newRecord;
        }
        static void DisplayRecord(student[] hashTable, string examNo)
        {
            student oldRecord;
            string examNo;
            Console.Clear();

            Console.WriteLine("Enter the exam number: ");
            examNo = Console.ReadLine();
            while examNo!= 4


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}