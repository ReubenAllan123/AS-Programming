using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] theStack = new string[10];
            int NFS = 0;
            bool running = true;
            int i = 0;
            
            while (running == true)
            {
                switch (choice())
                {
                    case (1):
                        push(ref NFS, theStack);
                        break;
                    case (2):
                        pop(ref NFS, theStack);
                        break;
                    case (3):
                        output(theStack);
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
            Console.Clear();
            int choice;
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Output the stack");
            Console.WriteLine("4. End program");
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }
        public static void push(ref int NFS, string[] theStack)
        {
            Console.Write("Enter data to add to the stack: ");
            if (NFS < theStack.Length)
            {             
                theStack[NFS] = Console.ReadLine();
                NFS++;
            }
            else
            {
                Console.WriteLine("Stack full.");
            }         
        }
        public static void pop(ref int NFS, string[] theStack)
        {
            if (NFS > 0)
            {
                NFS--;
                Console.WriteLine($"{NFS}] {theStack[NFS]}");
                theStack[NFS] = "";
            }
            else
            {
                Console.WriteLine("Stack empty.");
            }
        }
        public static void output(string[] theStack)
        {
            Console.WriteLine("Stack Output:");
            for (int i = 0; i < theStack.Length; i++)
            {
                Console.WriteLine($"{i}] {theStack[i]}");
            }
            Console.ReadLine();
        }
    }
}
