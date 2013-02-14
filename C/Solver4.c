#include <stdio.h>
#include <string.h>
#include "Common.h"

BOOL isPalindrome(int number)
{
	char str[] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	char *start, *end;

	sprintf_s(str, 10, "%i", number);
	start = str;
    end = str + strlen(str) - 1;

	while(start < end)
	{
		if (*(start++) != *(end--))
			return FALSE;
	}

    return TRUE;
}

int calculateAndCheckPalindrome(int i, int j)
{
    int product = i * j;
    return i != j && isPalindrome(product) ? product : j > 100 ? calculateAndCheckPalindrome(i, j - 1) : 0;
}

int calculate4(int i)
{
    return (i > 100) ?  max(calculateAndCheckPalindrome(i, i - 1), calculate4(i - 1)) : 0;
}

int Solver4()
{
    return calculate4(999);
}