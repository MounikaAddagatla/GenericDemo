using System;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Demo Examples");
            Generics<int> genericDemo = new Generics<int>();
            genericDemo.MaximumOfNumber(20, 50, 25);
            Console.ReadLine();
        }
    }
    
}
