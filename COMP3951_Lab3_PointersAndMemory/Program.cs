namespace COMP3951_Lab3_PointersAndMemory
{
    internal class Program
    {
        // Two really important numbers
        int myNum = 11239900;
        int myNum2 = 1000123012;

        // Using pointers to swap values!
        unsafe void coolSwap(int *a, int *b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }

        public override string ToString()
        {
            return $"myNum: {myNum}, myNum2: {myNum2}";
        }

        static void Main(string[] args)
        {
            //// Wait, these numbers exist in an object
            //Program p = new Program();

            //Console.WriteLine(p);
            //// Objects are on the heap...
            //// Moveable by the GC...
            //// What can we do to make a program that let's us swap the values of the ints in this class?

            //unsafe
            //{
            //    // That's right, we need to fix the numbers and get the address of them
            //    // Now our super fast and memory efficient program will work
            //    fixed (int* n1 = &p.myNum, n2 = &p.myNum2) 
            //    {
            //        p.coolSwap(n1, n2);
            //    }
            //}

            //Console.WriteLine("Swapped!");
            //Console.WriteLine(p);

            int[] input = { 10, 20, 30, 40, 50, 60 };
            FixedObjectSolved fso = new FixedObjectSolved(input);
            Console.WriteLine(fso);
            unsafe
            {
                fixed (int* arrHead = fso.myNums) fso.reverseIntArray(arrHead, fso.myNumsSize);
            }
            Console.WriteLine(fso);
            
        }
    }
}
