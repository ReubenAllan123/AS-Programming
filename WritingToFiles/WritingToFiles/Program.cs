using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] Teams = new string[16];
            string fileName = @"teams.txt";
            addTeams(Teams);
            writeTeams(Teams, fileName);
        }
        static void addTeams(string[] Teams)
        {
            for (int i = 0; i < Teams.Length; i++)
            {
                Console.Write($"Enter team name #{i + 1}: ");
                Teams[i] = Console.ReadLine();
            }
        }
        static void writeTeams(string[] Teams, string fileName)
        {
            using (StreamWriter CurrentFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < Teams.Length; i++)
                {
                    CurrentFile.WriteLine(Teams[i]);
                }
            }
        }
    }
}

