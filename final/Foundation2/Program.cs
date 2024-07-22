using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 S. 1st E.", "Pocatello", "Idaho", "USA");
        Address a2 = new Address("281 Rotonda Manzaneda", "Ciudad del Este", "Iguazu", "Paraguay");
        Customer c1 = new Customer("Jhon", a1);
        Customer c2 = new Customer("Juan", a2);
        Product p1 = new Product("Hard box", 23, 1, 20);
        Product p2 = new Product("Shoes", 24, 80, 1);
        Product p3 = new Product("Battery", 25, 10, 1);
        Product p4 = new Product("Water gun", 26, 15, 1);
        Product p5 = new Product("Wooden table", 27, 2, 15);
        Product p6 = new Product("Soccer ball", 28, 30, 2);
        Product p7 = new Product("Book", 29, 10, 5);
        List<Product> products = new List<Product>();
        products.Add(p3);
        products.Add(p2);
        products.Add(p1);
        List<Product> products2 = new List<Product>();
        products2.Add(p4);
        products2.Add(p5);
        products2.Add(p6);
        products2.Add(p7);
        Order o1 = new Order(c1, products);
        Order o2 = new Order(c2, products2);
        Console.WriteLine($"First order packet label: {o1.packetLabel()}");
        Console.WriteLine($"First order total cost: {o1.getTotalCost()}");
        Console.WriteLine($"First order shipping address: {o1.shippingLabel()}");
        Console.WriteLine($"Second order packet label: {o2.packetLabel()}");
        Console.WriteLine($"Second order total cost: {o2.getTotalCost()}");
        Console.WriteLine($"Second order shipping address: {o2.shippingLabel()}");
    }
}