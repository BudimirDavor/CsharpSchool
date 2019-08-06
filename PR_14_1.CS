#include "iostream.h"

void PromijeniNiz(double *p)
{
	for(int i=0;i<100;i++)
		*(p + i) *= 2;
}

void main()
{
	double *p = new double [100];
	for(int i=0;i<100;i++)
		*p++ = i + 1;
	p -= 100;

	PromijeniNiz(p);

	for(i=0;i<100;i++)
	{
		cout << *(p + i);
		cout << "\n";
	}
}
