#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,n3,n4,n5,pcount=0,pcount1=0,res;
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
    pcount=pcount+1;
    pcount1=pcount1+n1;
	}
	if(n2>0)
	{
    pcount=pcount+2;
    pcount1=pcount1+n2;
	}
	if(n3>0)
	{
    pcount=pcount+3;
    pcount1=pcount1+n3;
	}
	if(n4>0)
	{
    pcount=pcount+4;
    pcount1=pcount1+n4;
	}
	if(n5>0)
	{
    pcount=pcount+5;
    pcount1=pcount1+n5;
	}
	res=pcount1/pcount;
	printf("average of all positive=%d",res);
	getch();
}
	
