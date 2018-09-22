using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise.Exercises
{
    class AggregateOperations
    {
        public static void Ex1()
        {
            // Output how many numbers are in this list
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine(numbers.Count());
        }

        public static void Ex2()
        {
            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine(purchases.Sum());
        }

        public static void Ex3()
        {
            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine(prices.Max());
        }
    }
}
