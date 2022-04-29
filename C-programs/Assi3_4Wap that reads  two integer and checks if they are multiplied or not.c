#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,temp;
	printf("enter first number\n");
	scanf("%d",&n1);
	printf("enter second number\n");
	scanf("%d",&n2);
	if(n1>n2)
	{
	temp=n1;
	n1=n2;
	n2=temp;
	}
	if(n2%n1)
	{
	printf("multiplied");
	}
	else
	{
	printf("not multiplied");
	}
	getch();
}