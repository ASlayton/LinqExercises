using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Output:");
            FilteringOperationsFruit();
            Console.WriteLine("Number Output");
            FilteringOperationsNumbers();
            Console.WriteLine("Ordering Names Output");
            OrderingOperationsNames();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static void FilteringOperationsFruit()
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

        static void FilteringOperationsNumbers()
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

        static void OrderingOperationsNames()
        {
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend =
                from name in names
                orderby name descending
                select name;
            foreach (var name in descend)
            {
                Console.WriteLine(name);
            }
        }
    }
}
