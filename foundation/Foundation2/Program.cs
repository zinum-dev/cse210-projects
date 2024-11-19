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
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetTotal());
        
        
        



    }
}