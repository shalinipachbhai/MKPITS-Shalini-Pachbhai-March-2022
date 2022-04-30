#include<stdio.h>
#include<conio.h>
void main()
{
	int n,i,j=1,x=0;
	i=1;
	printf("enter number of lines:\n");
	scanf("%d",&n);
	for(i=1;i<=n;i++)
	{
		printf("%d%d%d\n",i,i*i,i*i*i);
	}
	getch();
}