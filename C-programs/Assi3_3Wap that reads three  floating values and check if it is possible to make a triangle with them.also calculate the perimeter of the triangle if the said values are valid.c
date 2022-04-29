#include<stdio.h>
#include<conio.h>
void main()
{
	float n1,n2,n3,perimeter;
	printf("enter first number:\n");
	scanf("%f",&n1);
	printf("enter second number:\n");
	scanf("%f",&n2);
	printf("enter Third number:\n");
	scanf("%f",&n3);
	if((n2+n3)>n1&&(n1+n3)>n2&&(n1+n2)>n3)
	{
	perimeter=n1+n2+n3;
	printf("perimeter:%f",perimeter);
	}
	else
	{
		printf("impossible to make triangle");
	}
}