#include<stdio.h>
#include<conio.h>
void add();
void main()
{
    add();
}
void add()
{
	int num1,num2,res;
	printf("enter two number");
	scanf("%d%d",&num1,&num2);
	res=num1+num2;
	printf("%d",res);
	
}