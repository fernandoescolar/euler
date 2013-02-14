#include "Common.h"
#include <string.h>

#define LIMIT 21
void doDouble(byte *b)
{
	byte *p = b;
	BOOL carry = FALSE;

	while(*p != LIMIT)
	{
		*p = (*p) << 1;
		
		if (carry)
		{
			*p += 1;
			carry = FALSE;
		}

		if (*p >= 10)
		{
			carry = TRUE;
			*p = (*p) - 10;
		}

		p++;
	}
}

int calculate16()
{
	int result = 0;
	byte b[310];
	int i;
	memset(b, 0, sizeof b);
	b[0] = 2;
	b[309] = LIMIT;

	for(i = 2; i <= 1000; i++)
	{
		doDouble(&b[0]);
	}

	for(i = 0; i < 309; i++)
	{
		result += b[i];
	}

	return result;
}

int Solver16()
{
	return calculate16();
}