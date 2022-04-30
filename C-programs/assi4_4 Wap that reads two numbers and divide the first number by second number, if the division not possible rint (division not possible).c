#include<stdio.h>
#include<conio.h>
int main()
{ 
float div;
int y,x;
printf("enter first number");
scanf("%d",&x);
printf("enter second number");
scanf("%d",&y);
if(y!=0)
{
	div=x/y;
	printf("%f\n",div);
}
else
{
	printf("division not possible");
}
getch();
}