using System;
using System.Diagnostics;

namespace Bruteforce
{
    class Program
    {
        static char[] Match = {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p',
                        'q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
                        'Q','R','S','T','U','V', 'W', 'X','Y','Z','!','?', '.', ' ','*','-','+', '_'};

        static string FindPassword;
        static int Combi;
        static string space;
        static int Characters;

        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("C:/Users/Messelken/Desktop/test.7z/test/teest.txt");

            Console.Title = "Brute Force";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ALL FILES LOADED...");
            Console.WriteLine(space);
            Console.WriteLine("Enter file location:");
            Console.ForegroundColor = ConsoleColor.White;

            space = " ";
            int Count;

            FindPassword = (Console.ReadLine());
            Characters = FindPassword.Length;
            Console.Clear();

            DateTime today = DateTime.Now;
            today.ToString("yyyy-MM-dd_HH:mm:ss");
            Console.WriteLine(space);
            Console.WriteLine("START:\t{0}", today);

            for (Count = 0; Count <= 15; Count++)
            {
                Recurse(Count, 0, "");
            }
        }

        static void Recurse(int Lenght, int Position, string BaseString)
        {
            int Count = 0;

            for (Count = 0; Count < Match.Length; Count++)
            {
                Combi++;
                if (Position < Lenght - 1)
                {
                    Recurse(Lenght, Position + 1, BaseString + Match[Count]);
                }
                if (BaseString + Match[Count] == FindPassword)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your password is: " + FindPassword);
                    Console.WriteLine("Your password is: " + Characters + " character(s) long");
                    Console.ForegroundColor = ConsoleColor.White;
                    DateTime today = DateTime.Now;
                    today.ToString("yyyy-MM-dd_HH:mm:ss");
                    Console.WriteLine(space);
                    Console.WriteLine("END:\t{0}\nCombi:\t{1}", today, Combi);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}
