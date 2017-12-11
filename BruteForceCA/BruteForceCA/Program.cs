using System;
using System.Diagnostics;
using System.IO.Compression;

namespace Bruteforce
{
    class Program
    {
        static char[] Match = {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p',
                        'q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
                        'Q','R','S','T','U','V', 'W', 'X','Y','Z','!','?', '.', ' ','*','-','+', '_'};

        static int m_Combi;
        static DateTime m_startTime;

        static void Main(string[] args)
        {
            Console.Title = "Brute Force";

            Console.WriteLine("Enter file location:");
            Console.ForegroundColor = ConsoleColor.White;

            int Count;

            string path = Console.ReadLine();

            Console.Clear();

            DateTime today = DateTime.Now;
            m_startTime = today;

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
                m_Combi++;
                Console.WriteLine(BaseString + Match[Count]);

                if (Position < Lenght - 1)
                {
                    Recurse(Lenght, Position + 1, BaseString + Match[Count]);
                }
                if ("h1r" == BaseString + Match[Count])
                {
                    string password = BaseString + Match[Count];
                    passwordFound(password);
                }
            }
        }

        private static void passwordFound(string password)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HACK COMPLETE");
            Console.WriteLine();
            Console.Write("Seeked password: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(password);
            Console.ForegroundColor = ConsoleColor.White;
            DateTime today = DateTime.Now;
            today.ToString("yyyy-MM-dd_HH:mm:ss");
            var delta = today - m_startTime;
            Console.WriteLine();
            Console.WriteLine("Tested:\t{0} Combinations\nInit:\t{1}\nDone:\t{2}\n", m_Combi, m_startTime, today);
            Console.ReadLine();
            Environment.Exit(0);
        }

        /*static bool openZip(string password)
        {
            try
            {
                using (ZipFile archive = new ZipFile(@"c:\path\to\your\password\protected\archive.zip",))
                {
                    archive.Password = password;
                    archive.Encryption = EncryptionAlgorithm.PkzipWeak; // the default: you might need to select the proper value here
                    archive.StatusMessageTextWriter = Console.Out;

                    archive.ExtractAll(@"c:\path\to\unzip\directory\", ExtractExistingFileAction.Throw);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }*/
    }
}
