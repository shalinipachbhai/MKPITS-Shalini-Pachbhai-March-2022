#include<stdio.h>
#include<conio.h>
void main()
{
	int a, b;
	printf("enter two pairs value");
	scanf("%d%d",&a,&b);
	if(a!=b)
	{
		if (b>a)
		{
			printf("Ascending order\n");
		}
		else
		{
			printf("Descending order\n");
		}
	}
}