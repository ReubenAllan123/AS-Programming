using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 1)
            {
                Console.Write("Enter a positive integer: ");
                int.TryParse(Console.ReadLine(), out number);
            }

            int answer = FactorialN(number);

            Console.WriteLine($"Answer for {number}! is: {answer}.");
            Console.ReadKey();
        }
        static int FactorialN(int number)
        {
            int answer;
            if (number == 1)
            {
                answer = 1;
            }
            else
            {
                answer = number * FactorialN(number - 1);
            }
            return answer;
        }
    }
}
