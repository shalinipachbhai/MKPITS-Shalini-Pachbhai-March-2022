#include<stdio.h>
#include<conio.h>
int main()
{
	float i,j=1;
	float s=0;
    for(i=0;i<=1;i+2)
	{
	s=s+(i/j);
	j=j*2;
	i=i+2;
	}
	printf("value of s=%f",s);
	getch();
}