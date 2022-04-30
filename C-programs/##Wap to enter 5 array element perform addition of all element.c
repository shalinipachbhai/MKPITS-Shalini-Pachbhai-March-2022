#include<stdio.h>
#include<conio.h>
void main()
{
	int a[5],i,add=0;
	printf("enter five number\n");
	for(i=0;i<=4;i++)
	{
		printf("a[%d]:",i);
		scanf("%d",&a[i]);
	}
	printf("\n");
	for(i=0;i<=4;i++)
	{
		add=add+a[i];
	}
	printf("addition:%d",add);
}