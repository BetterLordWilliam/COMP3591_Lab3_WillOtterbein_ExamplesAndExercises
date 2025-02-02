using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3951_Lab3_PointersAndMemory
{
internal class FixedObjectUnsolved
{
    int[] myNums;
    int myNumsSize;

    public FixedObjectUnsolved(int[] myNums)
    {
        this.myNums = myNums;
        myNumsSize = myNums.Length;
    }

    public void Test()
    {
        // Invoke your method...
    }

    // Unsafe code
    // Implement the given C code to reverse the my nums array in an unsafe method.
}
}
