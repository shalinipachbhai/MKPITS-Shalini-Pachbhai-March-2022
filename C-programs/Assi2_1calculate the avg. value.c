#include<stdio.h>
#include<conio.h>
void main()
{
	float wi1,ni1,wi2,ni2,result;
	printf("weight item 1 and 2");
	scanf("%f%f",&wi1,&wi2);
	printf("no. of item 1 and 2");
	scanf("%f%f",&ni1,&ni2);
	result=((wi1*ni1)+(wi2*ni2))/((ni1+ni2));
	printf("avg.value=%f\n",result);
	getch();
	
}