using ExampleAction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleAction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Action
            //List<Product> list = new List<Product>();
            //list.Add(new Product("Tv", 900.00));
            //list.Add(new Product("Mouse", 50.00));
            //list.Add(new Product("Tablet", 350.50));
            //list.Add(new Product("HD Case", 80.90));

            ////list.ForEach(UpdatePrice);
            ////Action<Product> action1 = UpdatePrice;
            ////list.ForEach(action1);

            ////Action<Product> action2 = p => { p.Price += p.Price * 0.1; };

            ////list.ForEach(action2);

            ////list.ForEach(new Action<Product>((p) => { p.Price += p.Price * 0.1; }));

            //list.ForEach((p) => { p.Price += p.Price * 0.1; });

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Func
            Func<Product, string> func = NameUpper;

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(func).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);  
            }

            #endregion


            Console.ReadKey();
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        
    }
}
