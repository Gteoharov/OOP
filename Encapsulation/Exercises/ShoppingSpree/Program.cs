using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var peoples = new List<Person>();
            var products = new List<Product>();

            var firstLine = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            var secoundLine = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < firstLine.Length; i+= 2)
            {
                string name = firstLine[i];
                decimal money = decimal.Parse(firstLine[i + 1]);

                try
                {
                    var person = new Person(name, money);
                    peoples.Add(person);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            for (int i = 0; i < secoundLine.Length; i += 2)
            {
                string name = secoundLine[i];
                decimal cost = decimal.Parse(secoundLine[i + 1]);

                try
                {
                    var product = new Product(name, cost);
                    products.Add(product);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    foreach (var currentPerson in peoples)
                    {
                        string boughtProducts = string.Empty;

                        if (currentPerson.Bag.Count == 0) 
                        {
                            boughtProducts = "Nothing bought";
                        }
                        else
                        {
                            boughtProducts = string.Join(", ", currentPerson.Bag.Select(p => p.Name));
                        }
                        Console.WriteLine($"{currentPerson.Name} - {boughtProducts}");
                    }
                    break;
                }

                string personName = command[0];
                string productName = command[1];
                var person = peoples.FirstOrDefault(p => p.Name == personName);
                var product = products.FirstOrDefault(p => p.Name == productName);
                Console.WriteLine(person.BuyProduct(product));
            }
        }
    }
}
