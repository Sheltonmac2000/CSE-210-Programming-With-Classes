using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string inputInfo;

        do {
            Console.WriteLine("Do you want to login?");
            string inputInfo = Console.ReadLine();
            Console.WriteLine("What is your name ?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcom back {userName}");
        } while (inputInfo == "yes" );

    }
}