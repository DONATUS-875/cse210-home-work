using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("456 Broadway Avenue", "Brooklyn", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        Address address2 = new Address("45 King Street", "London", "London", "UK");
        Customer customer2 = new Customer("James Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P003", 100, 1));
        order2.AddProduct(new Product("Keyboard", "P004", 75, 1));
        order2.AddProduct(new Product("Monitor","P005", 300, 2));

        List<Order> orders = new List<Order> {order1, order2};

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total cost: ${order.GetTotalCost()}\n");
        }
    }

}