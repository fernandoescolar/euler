#include <stdio.h>
#include <stdlib.h>
#include "Solvers.h"


void printSolution(int problemNumber, int expected, int result)
{
	if (result == expected)
		printf("Problem %i: %i", problemNumber, result);
	else
		printf("Problem %i failed. Expected %i and the result was %i", problemNumber, expected, result);

	printf("\n");
}

int main( int argc, const char* argv[] )
{
	printf( "\nProject Euler:\n\n" );
	printSolution(1, 233168, Solver1());
	printSolution(2, 4613732, Solver2());
	printSolution(3, 6857, Solver3());
	printSolution(4, 906609, Solver4());
	printSolution(5, 232792560, Solver5());

	printf( "\n\n");
	system("pause");
	return 0;
}