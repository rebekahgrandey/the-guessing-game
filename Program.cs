using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user! Guess the number.");
            Console.Write("Guess number --->");
            Console.ReadLine();
            string UserAnswer = Console.ReadLine();
            Console.Write(UserAnswer);
        }
    }
}