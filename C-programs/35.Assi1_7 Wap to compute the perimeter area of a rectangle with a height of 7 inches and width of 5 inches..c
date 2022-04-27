#include<stdio.h>
#include<conio.h>
void main()
{
	int height=7,width=5;
	int perimeter,area;
	perimeter=2*(height+width);
	printf("perimeter of rectangle=%d inches\ns",perimeter);
	
	area=height*width;
	printf("area of rectangle=%d inches\n",area);
	getch();
	
}