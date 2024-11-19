using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Estrada da Cacuia", "Teresópolis", "Rio de Janeiro", "Brazil");
        Customer customer1 = new Customer("Marco Aurelio",address1);
        List<Product> products1 =
        [
            new Product("apple",0057,0.37,12),
            new Product("banana",0059,0.5,15),
            new Product("pear",0072,1.2,4),
        ];
        Order order1 = new Order(customer1,products1);
        DisplayOrder(order1);
        
        

        Address address2 = new Address("Stanwood Ave", "Jacksonville", "Florida", "USA");
        Customer customer2 = new Customer("Marco Aurelio",address2);
        List<Product> products2 =
        [
            new Product("rice",0237,4.75,3),
            new Product("fish",0493,10.02,2),
            new Product("watermelon",0062,2.6,1),
        ];
        Order order2 = new Order(customer2,products2);
        DisplayOrder(order2);
        
        



    }

    private static void DisplayOrder(Order order)
    {
        Console.Write(new string('-',25));
        Console.Write(" Order ");
        Console.WriteLine(new string('-',25));
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order.GetTotal());
    }
}