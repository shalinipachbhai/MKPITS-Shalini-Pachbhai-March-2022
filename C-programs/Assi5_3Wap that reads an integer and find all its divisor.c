#include<stdio.h>
#include<conio.h>
int main()
{
	int i,n;
	printf("enter any integer number\n");
	scanf("%d",&n);
	for(i=1;i<=n;i++)
	{
		if(n%1==0)
		{
			printf("%d\n",i);
		}
	}
}