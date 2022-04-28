#include<stdio.h>
#include<conio.h>
void main()
{
	int sec, hour, minutes,second;
	printf("enter second");
	scanf("%d",&sec);
	hour=(sec/3600);
	minutes=(sec-(3600*hour))/60;
	second=(sec-(3600*hour)-(minutes*60));
	printf("hour,minutes,second=%d%d%d\n",hour,minutes,second);
	getch();
}