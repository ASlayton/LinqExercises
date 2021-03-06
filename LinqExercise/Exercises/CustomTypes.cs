﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise.Exercises
{
    class CustomTypes
    {
        // Build a collection of customers who are millionaires
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        // Define a bank
        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }

        public static void MillionairesClub()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>()
            {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            var millionairesClub =
                from customer in customers
                where customer.Balance >= 1000000
                select customer;
            foreach (var customer in millionairesClub)
            {
                Console.WriteLine(customer.Name);
            }
            /* 
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */
            var MillionairesByBank = millionairesClub
                .GroupBy(cust => cust.Bank);

            foreach (var millionaire in MillionairesByBank)
            {
                Console.WriteLine($"{millionaire.Key} {millionaire.ToList().Count}");
            }

            //Create our variable, this is a new list of both lists combined
            var MillionairesAndBanks =
            // For every entry in the list of customers
                from customer in customers
            // We only want the millionaires
                where customer.Balance >= 1000000
            // if the bank symbol matches the customer bank key, that customer gets another
            // key with the bank name
                join bank in banks on customer.Bank equals bank.Symbol into customerBank
                select new { customer.Name, Bank = customerBank.First().Name };
            foreach (var customer in MillionairesAndBanks)
            {
                Console.WriteLine($"{customer.Name} is a millionaire at {customer.Bank}, lucky bastard.");
            }


        }
     }
}
