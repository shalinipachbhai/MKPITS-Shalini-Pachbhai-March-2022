#include<stdio.h>
#include<conio.h>
int main()
{
	int i,sum=0,a[7];
	printf("enter the array element\n");
	for(i=0;i<7;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<7;i++)
	{
		if(a[i]!=5&&a[i+1]!=6)
		{
		sum=sum+a[i];
		}
		
	}
	printf("sum of values in array those starting with 5 followed by 6: %d",sum-6);
}