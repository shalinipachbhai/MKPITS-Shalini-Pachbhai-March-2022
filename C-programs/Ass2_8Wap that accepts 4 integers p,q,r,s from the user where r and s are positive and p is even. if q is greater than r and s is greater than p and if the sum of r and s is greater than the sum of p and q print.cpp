#include<stdio.h>
#include<conio.h>
void main()
{
	int p,q,r,s;
	printf("enter the four integer");
	scanf("%d%d%d%d",&p,&q,&r,&s);
	if((q>r)&&(s>p)&&((r+s)>(p+q))&&(r>0)&&(s>0)&&(p%2==0))
	{
		printf("correct values\n");
	}
	else
	{
		printf("wrong values\n");
	}
	getch();
}