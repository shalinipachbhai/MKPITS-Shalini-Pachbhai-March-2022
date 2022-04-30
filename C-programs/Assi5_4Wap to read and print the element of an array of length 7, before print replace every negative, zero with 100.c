#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[7],n;
	printf("enter seven integer number\n");
	for(i=0;i<7;i++)
	{
		scanf("%d",&n);
		if(n>0)
		{
			a[i]=n;
		}
		else
		{
			a[i]=100;
		}
	}
	
}