#include<stdio.h>
#include<conio.h>
void main()
{
	int a;
	
	float b;
	printf("enter total distance in km");
	scanf("%d",&a);
	printf("enter total fuel spent in liters");
	scanf("%f",&b);
	printf("avg.consumptionkm/lit=%f",a/b);
	getch();
}