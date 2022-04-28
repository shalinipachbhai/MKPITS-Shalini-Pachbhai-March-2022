#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,n3,n4,n5,negative=0,positive=0;
	printf("enter first number\n");
	scanf("%d",&n1);
	printf("enter second number\n");
	scanf("%d",&n2);
	printf("enter third number\n");
	scanf("%d",&n3);
	printf("enter fourth number\n");
	scanf("%d",&n4);
	printf("enter fifth number\n");
	scanf("%d",&n5);
	if(n1>0)
	{
		positive=positive+1;
	}
	else
	{
		negative=negative+1;
	}
		if(n2>0)
	{
		positive=positive+1;
	}
	else
	{
		negative=negative+1;
	}
	if(n3>0)
	{
	positive=positive+1;
	}
	else
	{
	negative=negative+1;
	}
	if(n4>0)
	{
	positive=positive+1;
	}
	else
	{
	negative=negative+1;
	}
	if(n5>0)
	{
	positive=positive+1;
	}
	else
	{
	negative=negative+1;
	}
	printf("count of positive:%d\n",positive);
	printf("count of negative:%d\n",negative);
}