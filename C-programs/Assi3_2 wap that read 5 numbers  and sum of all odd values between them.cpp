#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,n3,n4,n5,odd_res=0;
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
	if(n1%32!=0)
	{
	odd_res=odd_res+n1;
	}
	if(n2%2!=0)
	{
	odd_res=odd_res+n2;
	}
	if(n3%2!=0)
	{
	odd_res=odd_res+n3;
	}
	if(n4%2!=0)
	{
	odd_res=odd_res+n4;
	}
	if(n5%2!=0)
	{
	odd_res=odd_res+n5;
	}
	printf("addition of all odd values:%d\n",odd_res);
	
}