using System;

class Program
{
    static void Main(string[] args)
    {
        A a = new();
        Console.WriteLine("Hello Sandbox World! Starting the course!!");
        A.Amor();
    }
}

class A{
    
    public static void Amor(){
        Console.WriteLine("Amamos o Vicente!");
    }
}