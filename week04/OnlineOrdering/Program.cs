// This program tracks product orders for customers.
// It calculates the total cost, generates packing labels, and shipping labels based on customer addresses.
using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Create some products
    Product product1 = new("Automatic Standing Desk", "AT025", 1250.91f, 1);
    Product product2 = new("Smart Mirror", "SV018", 21.87f, 2);
    Product product3 = new("Portable Air Purifier", "PP090", 53.95f, 1);
    Product product4 = new("Starlink Wifi", "SI013", 205.90f, 1);
    Product product5 = new("Wireless Keyboard", "WD019", 27.90f, 2);
    Product product6 = new("Bluetooth Speaker", "BS054", 14.96f, 2);

    // Create customers and their addresses
    Customer customer1 = new Customer("Steven Jackson", new Address("13 Prospect St", "San Diego", "California", "USA"));
    Customer customer2 = new Customer("Bane Tootil", new Address("237 Gotham St", "London", "England", "UK"));

    // Create orders
    Order order1 = new Order(new List<Product> { product6, product4, product3 }, customer1);
    Order order2 = new Order(new List<Product> { product2, product5, product1}, customer2);

    // Display the first order details
    Console.WriteLine($"Customer No. 1");
    Console.WriteLine(order1.GetPackingLabel());
    Console.WriteLine(order1.GetShippingLabel());
    Console.WriteLine($"Total Cost: ${order1.CalculateTotal()}\n");

    // Display the second order details
    Console.WriteLine($"Customer No. 2");
    Console.WriteLine(order2.GetPackingLabel());
    Console.WriteLine(order2.GetShippingLabel());
    Console.WriteLine($"Total Cost: ${order2.CalculateTotal():F2}\n");
  }
}