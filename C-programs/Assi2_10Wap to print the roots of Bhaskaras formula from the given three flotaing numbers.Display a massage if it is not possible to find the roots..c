#include<stdio.h>
#include<conio.h>
void main()
{
	float a,b,c,x1,x2,f;
	printf("enter the first number");
	scanf("%f",&a);
	printf("enter the second number");
	scanf("%f",&b);
	printf("enter the third number");
	scanf("%f",&c);
	f=(b*b)-(4*(a)*(c));
	if(f>0 && a!=0)
	{
		x1=(-b+f)/(2*a);
		x2=-b-f/(2*a);
		printf("root1=%f\n",x1);
		printf("root2=%f\n",x2);
	}
	else
	{
		printf("\n impossible to find the root");
	}
	
	getch();
}