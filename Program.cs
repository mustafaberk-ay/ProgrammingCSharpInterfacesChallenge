using System;

namespace ProgrammingCSharpInterfacesChallenge
{
    internal class Program
    {
        class RandomNumberGenerator : IRandomizable
        {
            public double GetRandomNum(double upperBound)
            {
                Random rnd = new Random();
                double seed = rnd.NextDouble();
                return seed * upperBound;
            }
        }

        static void Main(string[] args)
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            do
            {
                Console.WriteLine("Enter a number for the upper bound:");
                string userInput = Console.ReadLine();
                if(userInput == "exit")
                {
                    return;
                }
                try
                {
                    int upperBound = Convert.ToInt32(userInput);
                    Console.WriteLine($"Random number between 0 and {upperBound}: {randomNumberGenerator.GetRandomNum(upperBound)}");
                }
                catch (Exception)
                {}
            } while (true);
        }
    }

    internal interface IRandomizable
    {
        double GetRandomNum(double upperBound);
    }
}