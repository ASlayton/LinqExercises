using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            FilteringOperationsFruit();
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
    }
}
