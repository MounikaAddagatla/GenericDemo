using System;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Value");
            Generics<int> genericDemo = new Generics<int>();
            genericDemo.MaximumOfNumber(20.1, 50.1, 25.1);
            Console.ReadLine();
        }
    }
    
}
