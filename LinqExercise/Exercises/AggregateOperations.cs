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
    }
}
