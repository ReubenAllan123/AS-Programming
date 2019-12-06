using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mass = 0;
            using (StreamReader CurrentFile = new StreamReader("masses"))
            {
                for (int i = 0; i < 2; i++)
                {
                    decimal.TryParse(CurrentFile.ReadLine(), out mass);
                    mass = mass / 3;
                    mass = Math.Floor(mass);
                    mass = mass - 2;

                    Console.WriteLine(mass);

                }
            }
        }
    }
}
