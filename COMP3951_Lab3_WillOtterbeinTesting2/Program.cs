using System.Numerics;
using PassByValue;
using PassByReference;

namespace COMP3951_Lab3_WillOtterbeinTesting2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Passing by value");
            PassByValue.VectorOperations.Test();

            Console.WriteLine("Passing by reference");
            PassByReference.VectorOperations.Test();
        }
    }
}
