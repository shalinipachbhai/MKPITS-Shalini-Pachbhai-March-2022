#include<stdio.h>
#include<conio.h>
void main()
{
	float x1,x2,y1,y2,distance;
	printf("enter x1,y1");
	scanf("%f%f",&x1,&x2);
	printf("%f%f",x2,y2);
	scanf("%f%f",&x2,&y2);
	distance=((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
	printf("distance between the point=%f", distance);
	getch();
}