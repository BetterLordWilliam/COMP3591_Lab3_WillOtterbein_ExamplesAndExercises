#include <stdio.h>
#include <stdlib.h>

void printIntArray(int* arrHead, int arrLength)
{
	printf("[%d", *(arrHead + 0));
	for (int i = 1; i < arrLength; i++)
	{
		printf(",%d", *(arrHead + i));
	}
	printf("]\n");
}

// Reverse an integer array using pointers 
// This is the method you need to implement in C#
void reverseIntArray(int* arrHead, int arrLength)
{
	for (int i = 0; i < arrLength/2; i++)
	{
		int temp = *(arrHead + i);
		*(arrHead + i) = *(arrHead + arrLength - 1 - i);
		*(arrHead + arrLength - 1 - i) = temp;
	}
}

// Swap two numbers
void swapTwoNumbers(int* num1, int* num2)
{
	int temp = *num1;
	*num1 = *num2;
	*num2 = temp;
}

int main(int argc, char** argv)
{
	// Swapping
	int num1 = 1231;
	int num2 = 5431;
	
	printf("num1: %d, num2: %d\n", num1, num2);
	swapTwoNumbers(&num1, &num2);
	printf("Swapped!\nnum1: %d, num2: %d\n", num1, num2);

	// Reversing an array
	int integerArray[] = {10,20,30,40,50};
    int integerArray2[] = {40,30,20,10};
    int integerArraySize = sizeof(integerArray) / sizeof(int);
    int integerArraySize2 = sizeof(integerArray2) / sizeof(int);
    printIntArray(integerArray, integerArraySize);
    printIntArray(integerArray2, integerArraySize2);


    reverseIntArray(integerArray, integerArraySize);
    printIntArray(integerArray, integerArraySize); 

    reverseIntArray(integerArray2, integerArraySize2);
    printIntArray(integerArray2, integerArraySize2);

    printf("... Enter a character ...");
    getchar();
}
