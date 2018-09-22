using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise.Exercises
{
    class OrderingExercises
    {
        static public void OrderingOperationsNames()
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

        static public void OrderingOperationsNumbers()
        {
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var ascendingOrder =
                from num in numbers
                orderby num ascending
                select num;

            foreach (var num in ascendingOrder)
            {
                Console.WriteLine(num);
            }
        }
    }
}
