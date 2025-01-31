using System.Numerics;

using COMP3951_Lab3_WillOtterbeinTesting2_Pass_By_Value;
using COMP3951_Lab3_WillOtterbeinTesting2_Pass_By_Reference;

namespace COMP3951_Lab3_WillOtterbeinTesting2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Passing by value");
            COMP3951_Lab3_WillOtterbeinTesting2_Pass_By_Value.VectorOperations.Test();

            Console.WriteLine("Passing by reference");
            COMP3951_Lab3_WillOtterbeinTesting2_Pass_By_Reference.VectorOperations.Test();
        }
    }
}
