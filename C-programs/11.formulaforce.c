#include<stdio.h>
void main()
{
	int mass,accel,force;
	printf("enter the mass,accel");
	scanf("%d%d",&mass,&accel);
	force=mass*accel;
	printf("force=%d",force);
	getch();
}
