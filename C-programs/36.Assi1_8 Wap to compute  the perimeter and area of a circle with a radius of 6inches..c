#include<stdio.h>
#include<conio.h>

void main()
{
	float perimeter,area;
	float pi=3.142;
	int radi=6;
	
	perimeter=2*(pi*radi);
	printf("perimeter of circle=%f inches\n",perimeter);
	
	area=pi*radi*radi;
	printf("area of circle=%f inches\n",area);
	getch();
}