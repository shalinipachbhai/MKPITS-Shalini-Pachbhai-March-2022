#include<stdio.h>
#include<conio.h>
void  main()
{
	int i, a[6],n;
	printf("enter six number\n");
	for(i=0;i<5;i++)
	{
		printf("a[%d]:",i);
		scanf("%d",&a[i]);
	}
	printf("\n");
	for(i=5;i>0;i--)
	{
		printf("a[%d]=%d\n",i,a[i]);
	}
	getch();
}