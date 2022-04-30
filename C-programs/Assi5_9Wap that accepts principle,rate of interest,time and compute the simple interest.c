#include<stdio.h>
#include<conio.h>
void main()
{
	int p,r,t;
	float si;
	printf("enter principle,rate and time of interest\n");
	scanf("%d%d%d",&p,&r,&t);
	si=(p*r*t)/100;
	printf("simple interst=%f\n",si);
}