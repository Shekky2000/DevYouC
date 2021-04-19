using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Tim";
            string greeting = "Greetings guest! Please enter your name here to continue on your lovely journey.";
            string gratitude = "Thank you";
            string country1 = "New Zealand";
            string country2 = "Australia";
            string welcome = "Welcome to your Vacation Budget Planner. Here, we have the ability to help you plan for your vacation in one of the two countries that are on special.";

            Console.WriteLine($"{greeting}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"{gratitude} {name}!");
            Console.WriteLine($"        ");


            Console.WriteLine($"{welcome}");
            Console.WriteLine($"Please choose from either of these countries: ");
            Console.WriteLine($"{country1} or {country2}");
            Console.WriteLine($"Country: {country1}");
            Console.WriteLine($"Great selection!");
            Console.WriteLine($"{gratitude} {name}!");

            Console.ReadLine();


        }
    }
}
