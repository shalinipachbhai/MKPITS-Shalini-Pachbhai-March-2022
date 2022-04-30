#include<stdio.h>
#include<conio.h>
void main()
{
int i,a[5];
printf("enter five numbers\n");
for(i=0;i<4;i++)
{
	printf("a[%d]:",i);
	scanf("%d",&a[i]);
}
printf("\n");
for(i=0;i<4;i--)
{
	printf("a[%d]=%d\n",i,a[i]);
}
}