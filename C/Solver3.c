int calculate3(__int64 i, int divisor)
{
	while(i > divisor){
		if (i%divisor == 0) i /= divisor;
		else divisor++;
	}

	return divisor;
}

int Solver3()
{
    return calculate3(600851475143, 2);
}

        