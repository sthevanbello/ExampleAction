﻿using ExampleAction.Entities;
using System;
using System.Collections.Generic;

namespace ExampleAction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.ForEach(UpdatePrice);

            list.ForEach(new Action<Product>((p) => p.Price += p.Price * 0.1));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
