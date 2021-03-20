using DesignPatterns.BehavioralPatterns;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Design Patterns Console Application!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Please, choose a pattern type and press Enter: \n " +
                "1 - Creational Pattern \n 2 - Structural Pattern \n 3 - Behavioral Pattern \n");
            Console.WriteLine();

            Console.Write("Answer: ");
            var userInfo = Console.ReadLine();
            var chosenPattern = int.Parse(userInfo);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------");

            if (chosenPattern == 1)
            {

            }

            if (chosenPattern == 2) { }

            if (chosenPattern == 3)
            {
                Console.WriteLine("Now choose the behavioral pattern e press Enter (Don't forget to set a breakpoint!)");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("1 - Strategy Pattern:");
                Console.WriteLine();

                Console.Write("Answer: ");
                var behavioralPattern = int.Parse(Console.ReadLine());

                switch (behavioralPattern)
                {
                    case 1:
                        BehavioralPatternsManager.ExecuteStrategyPattern();
                        break;
                }

            }
        }
    }
}
