using System;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Value");
            Generics<int> genericDemo = new Generics<int>();
            genericDemo.MaximumOfValue("Dell","Apple","Hp");
            Console.ReadLine();
        }
    }
    
}
