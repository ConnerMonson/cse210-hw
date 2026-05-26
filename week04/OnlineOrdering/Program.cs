using System;

class Program
{
    static void Main(string[] args)
    {
    // addresses
    Address address1 = new Address("123 New Road Rd", "Austin", "Texas", "USA");
    Address address2 = new Address("321 Old Street St", "Vancouver", "British Columbia", "Canada");

    // customers
    Customer customer1 = new Customer("George Mazon", address1);
    Customer customer2 = new Customer("Alban Mork", address2);

    // products
    Product product1 = new Product("Applesauce", 3250, 1.50, 3);
    Product product2 = new Product("Banana", 4011, .60, 12);
    Product product3 = new Product("Grape Fruit", 2398, 2.00, 1);
    Product product4 = new Product("Peppers", 1234, 12.40, 5);
    Product product5 = new Product("Hand Sanitizer", 1235, 50.23, 1);

    // orders
    Order order1 = new Order(customer1);
    Order order2 = new Order(customer2);

    // add products to orders
    order1.AddProduct(product1);
    order1.AddProduct(product2);
    order1.AddProduct(product3);

    order2.AddProduct(product4);
    order2.AddProduct(product5);
    order2.AddProduct(product1);
    // display order info
    Console.WriteLine("Order 1\n");
    Console.WriteLine($"Packing Label: \n{order1.PackingLable()}\nShipping Label: \n{order1.ShippingLable()}\n\nTotal Price: ${order1.TotalCost()}");
    Console.WriteLine("Order 2\n");
     Console.WriteLine($"Packing Label: \n{order2.PackingLable()}\nShipping Label: \n{order2.ShippingLable()}\n\nTotal Price: ${order2.TotalCost()}");
    }
}