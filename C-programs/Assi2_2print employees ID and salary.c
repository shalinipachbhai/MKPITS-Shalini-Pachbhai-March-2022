#include<stdio.h>
#include<conio.h>
void main()
{
	char ID;
	int hour;
	float value,salary;
	printf("enter the emloyees ID");
	scanf("%c",&ID);
	printf("enter the working hours");
	scanf("%d",&hour);
	printf("salary amount/hour");
	scanf("%f",&value);
	salary=value*hour;
	printf("employees ID=%c\n salary=%f\n",ID,salary);
	getch();
}