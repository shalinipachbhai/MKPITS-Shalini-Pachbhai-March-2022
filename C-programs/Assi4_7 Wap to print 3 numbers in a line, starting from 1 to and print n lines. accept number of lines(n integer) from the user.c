#include<stdio.h>
#include<conio.h>
void main()
{
	int a,x=0,i,j=1;
	printf("enter number of lines");
	scanf("%d",&a);
	for(i=1;i<=a;i++)
	{
		while(x<3)
		{
			printf("%d",j++);
			x++;
		}
		x=0;
		printf("\n");
	}
	getch();
	

}