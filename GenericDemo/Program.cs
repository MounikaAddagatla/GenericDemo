using System;
using static GenericDemo.GenericSortMaxOfValue;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Value");
            int[] intArray = { 4, 11, 7 };
            float[] floatArray = { 2.5f, 2.2f, 2.8f };
            string[] stringArray = { "Apple", "Peach", "Banana" };
            FindMaximum<int> findMaximum1 = new FindMaximum<int>(intArray);
            FindMaximum<float> findMaximum2 = new FindMaximum<float>(floatArray);
            FindMaximum<string> findMaximum3 = new FindMaximum<string>(stringArray);
            Console.WriteLine("largest Integer  : " + findMaximum1.FindMax());
            Console.WriteLine("largest Float  : " + findMaximum2.FindMax());
            Console.WriteLine("largest String : " + findMaximum3.FindMax());
            Console.ReadLine();
        }
    }
    
}
ss