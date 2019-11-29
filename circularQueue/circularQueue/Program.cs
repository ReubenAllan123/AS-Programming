using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] theQueue = new string[10];
            int NFS = 0;
            int FOQ = 0;
            bool queueEmpty = true;
            bool queueFull = false;
            bool running = true;

            while (running == true)
            {
                switch (choice())
                {
                    case (1):
                        add(ref theQueue, ref NFS, ref queueEmpty, ref queueFull, FOQ);
                        break;
                    case (2):
                        remove(ref theQueue, ref NFS, ref FOQ, ref queueEmpty, ref queueFull);
                        break;
                    case (3):
                        output(theQueue);
                        break;
                    case (4):
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
            Console.WriteLine("1. Add to Queue");
            Console.WriteLine("2. Remove from Queue");
            Console.WriteLine("3. Output the Queue");
            Console.WriteLine("4. End program");
            Console.Write("Choose an option: ");
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }
        public static void add(ref string[] theQueue, ref int NFS, ref bool queueEmpty, ref bool queueFull, int FOQ)
        {
            Console.Write("Input data to add to the queue: ");
            theQueue[NFS] = Console.ReadLine();
            queueEmpty = false;
            NFS++;
            if (NFS == FOQ)
            {
                queueFull = true;
                Console.Write("ERROR: Queue is full, remove from Queue.");
            }
            if (NFS > 9)
            {
                NFS = 0;
            }           
            Console.ReadKey();
            Console.Clear();
        }
        public static void remove(ref string[] theQueue, ref int NFS, ref int FOQ, ref bool queueEmpty, ref bool queueFull)
        {
            theQueue[FOQ] = "";               
            Console.WriteLine("Element removed.");
            queueFull = false;
            FOQ++;
            if (FOQ == NFS)
            {
                queueEmpty = true;
                Console.WriteLine("ERROR: the Queue is empty, nothing to remove.");
            }
            if (FOQ > 9)
            {
                FOQ = 0;
            }      
            Console.ReadKey();
            Console.Clear();
        }
        public static void output(string[] theQueue)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}] {theQueue[i]}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}