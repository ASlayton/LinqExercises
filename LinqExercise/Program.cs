using System;
using System.Collections.Generic;
using System.Linq;
using LinqExercise.Exercises;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Output:");
            FilteringExercises.FilteringOperationsFruit();
            Console.WriteLine("Number Output");
            FilteringExercises.FilteringOperationsNumbers();
            Console.WriteLine("Ordering Names Output");
            OrderingExercises.OrderingOperationsNames();
            Console.WriteLine("Ordering Numbers Output");
            OrderingExercises.OrderingOperationsNumbers();
            Console.WriteLine("Aggregate Function 1 Output");
            AggregateOperations.Ex1();
            Console.WriteLine("Aggregate Function 1 Output");
            AggregateOperations.Ex2();
            // CLOSE TERMINAL
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        } 
    }
}
