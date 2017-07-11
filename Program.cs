using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //In Main method, create a list of value tuples that will hold individual transactions for a hardware 
            //business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            
            //Add 5, or more, transactions to the list.
            transactions.Add(("Hammers", 6.35, 12));
            transactions.Add(("Screwdrivers", 5.89, 10));
            transactions.Add(("Nails", .89, 27));
            transactions.Add(("Ladders", 22.75, 8));
            transactions.Add(("Measuring Tape", 3.99, 22));

            Console.WriteLine();
            
            //Iterate over the list of tuples and calculate how many total products you sold today, and what your 
            //total revenue was.
            double totalRevenue = 0;
            int totalProducts = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                totalRevenue += t.Item2 * t.Item3;
                totalProducts += t.Item3;

            }

            Console.WriteLine($"Products sold: {totalProducts}");
            Console.WriteLine($"Total Revenue: ${totalRevenue}");
        }
    }
}
