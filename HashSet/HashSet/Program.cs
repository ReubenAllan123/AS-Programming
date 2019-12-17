using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
           HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Adding the number 10, 8 and 2.");
            numbers.Add(10);
            numbers.Add(8);
            numbers.Add(2);
            Console.WriteLine($"Elements in HashSet: {numbers.Count}");

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();          
        }
    }
}
