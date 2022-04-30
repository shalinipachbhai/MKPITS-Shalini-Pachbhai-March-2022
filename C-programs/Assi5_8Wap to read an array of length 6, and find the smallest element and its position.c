#include<stdio.h>
#include<conio.h>
void main()
{
	int i, a[6],n;
	printf("enter six number\n");
	for(i=0;i<5;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i]<6)
		{
			printf("a[%d]=%d\n",i,a[i]);
			
		}
	}
}