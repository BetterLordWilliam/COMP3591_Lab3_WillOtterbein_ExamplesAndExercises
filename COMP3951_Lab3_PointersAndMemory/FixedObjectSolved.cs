using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3951_Lab3_PointersAndMemory
{
public class FixedObjectSolved
{
    public int[] myNums;
    public int myNumsSize;

    public FixedObjectSolved(int[] myNums)
    {
        this.myNums = myNums;
        myNumsSize = myNums.Length;
    }
    public override string ToString()
    {
        return $"{myNumsSize}: [{string.Join(",", myNums)}]";
    }

    // Reverse an integer array using pointers 
    // This is the method you need to implement in C#
    public unsafe void reverseIntArray(int* arrHead, int arrLength)
    {
        for (int i = 0; i < arrLength / 2; i++)
        {
            int temp = *(arrHead + i);
            *(arrHead + i) = *(arrHead + arrLength - 1 - i);
            *(arrHead + arrLength - 1 - i) = temp;
        }
    }

    // public unsafe void Test()
    // {
    //     // Invoke your method...
    //     fixed (int* arrHead = myNums) reverseIntArray(arrHead, myNumsSize);
    // }
}
}