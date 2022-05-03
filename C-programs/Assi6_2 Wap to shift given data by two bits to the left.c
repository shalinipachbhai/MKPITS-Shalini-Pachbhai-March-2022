#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b;
	printf(" read the integer from keyboard");
	scanf("%d",&a);
	printf("\n integer value =%d\n",a);
	a<<2;
	b=a;
	printf("the left shifted data is=%d\n",b);
	getch();
	
}