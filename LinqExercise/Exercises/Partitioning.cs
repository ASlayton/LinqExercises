using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise.Exercises
{
    class Partitioning
    {
        public static void Ex1()
        {
            /*
            Store each number in the following List until a perfect square
            is detected.
            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */      
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            var NumBeforeSquare = wheresSquaredo.TakeWhile(x => Math.Sqrt(x) % 1 != 0);
            foreach (var num in NumBeforeSquare)
            {
                Console.WriteLine(num);
            }
        }
    }
}
