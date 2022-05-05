#include<stdio.h>
#include<conio.h>
int fun(int x, int y);
void main()
{
	int a=2 , b=4,res;
	res=fun(a,b);
}
int fun(int x, int y)
{
	int r;
	r=x+y;
	return r;
}