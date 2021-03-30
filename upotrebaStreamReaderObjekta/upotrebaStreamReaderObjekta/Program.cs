using System;
using System.IO;
namespace CitanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\My Documents\NOOP\datoteka.txt");
            // Čitamo datoteku liniju po liniju
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            // Zatvaramo datoteku
            sr.Close();
            Console.ReadKey();
        }
    }
}