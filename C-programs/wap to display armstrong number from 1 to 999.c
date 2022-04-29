#include<stdio.h>
#include<conio.h>
void main()
{
	int num=001;
	int n,a,b,c,res,back;
	printf("armstrong number 1 to 999%num");
	while(num<=999)
	{
	back=num;
	a=n%10;
	n=n/10;
	b=n%10;
	n=n/10;
	c=n%10;
	res=(a*a*a)+(b*b*b)+(c*c*c);
	if(back==res)
	{
		printf("%d\n",res);
		
	}
	num++;
		
	}
	getch();
}