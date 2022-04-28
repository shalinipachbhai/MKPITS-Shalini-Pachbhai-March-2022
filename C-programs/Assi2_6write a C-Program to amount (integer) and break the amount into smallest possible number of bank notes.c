#include<stdio.h>
#include<conio.h>
void main()
{
	int amount,total;
	printf("enter the amount");
	scanf("%d",&amount);
	
	total=amount/100;
	printf("%d note of 100\n",total);
	amount=amount-(total*100);
	
	total=amount/50;
	printf("%d note of 50\n");
	amount=amount-(total*50);
	
	total=amount/20;
	printf("%d note of 20\n");
	amount=amount-(total*20);
	
	total=amount/10;
	printf("%d note of 10\n");
	amount=amount-(total*10);
	getch();
}