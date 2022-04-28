#include<stdio.h>
#include<conio.h>
void main()
{
	int D,days,years,months;
	printf("enter no. of days");
	scanf("%d",&days);
	years=days/365;
	days=days-(365*years);
	months=days/30;
	D=days-(months*30);
	printf("%d years\n months\n days\n",years,months);
	getch();
	
}