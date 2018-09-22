using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqExercise.Exercises
{
    class FilteringExercises
    {

        static public void FilteringOperationsFruit()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var queryFruit =
                from fruit in fruits
                where fruit[0] == 'L'
                select fruit;

            foreach (var fruit in queryFruit)
            {
                Console.WriteLine(fruit);
            }
        }


        static public void FilteringOperationsNumbers()
        {
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
               15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples =
                from num in numbers
                where num % 4 == 0 || num % 6 == 0
                select num;
            foreach (var num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }
        }
    }
}
