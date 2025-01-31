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

int main(int argc, char** argv)
{
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
