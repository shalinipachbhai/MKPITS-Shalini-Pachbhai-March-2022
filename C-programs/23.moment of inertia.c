#include<stdio.h>
void main()
{
	int L,w,I;
	printf("enter value of angular momentum angular velocity");
	scanf("%d%d",&L,&w);
	I=L/w;
	printf("I=%d",I);
	getch();
}
