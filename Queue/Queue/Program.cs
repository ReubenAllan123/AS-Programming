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
            bool running = true;
            while (running == true)
            {
                switch (choice())
                {
                    case (1):
                        add(ref theQueue, ref NFS);
                        break;
                    case (2):
                        remove(ref theQueue, ref NFS, ref FOQ);
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
        public static void add(ref string[] theQueue, ref int NFS)
        {
            if (NFS <= 10)
            {
                Console.Write("Input data to add to the queue: ");
                theQueue[NFS] = Console.ReadLine();
                NFS++;
            }
            else
            {
                Console.Write("ERROR: Queue is full, remove from Queue.");
            }
            Console.Clear();
        }
        public static void remove(ref string[] theQueue, ref int NFS, ref int FOQ)
        {       
            if (FOQ == NFS)
            {
                Console.WriteLine("ERROR: the Queue is empty, nothing to remove.");
                FOQ = 0;
                NFS = 0;
            }
            else if(FOQ >= 0)
            {
                theQueue[FOQ] = "";
                FOQ++;
                Console.WriteLine("Element removed.");
            }
            else
            {           
                Console.WriteLine("ERROR: the Queue is empty, nothing to remove.");
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
