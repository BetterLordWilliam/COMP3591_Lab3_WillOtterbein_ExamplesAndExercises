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
	for (int i = 0; i < arrLength; i++)
	{
		int* temp = *(arrHead + i);
		*(arrHead + i) = *(arrHead + arrLength - i - 1);
		*(arrHead + arrLength - i - 1) = *temp;
	}
}

int main(int argc, char** argv)
{
	int integerArray[] = {10,20,30,40,50};
	int integerArraySize = sizeof(integerArray) / sizeof(int);
	printf("%d", integerArraySize);
}