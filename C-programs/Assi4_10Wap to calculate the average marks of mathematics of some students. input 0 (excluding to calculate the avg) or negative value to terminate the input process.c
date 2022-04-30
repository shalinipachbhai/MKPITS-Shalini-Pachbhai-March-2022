#include<stdio.h>
#include<conio.h>
void main()
{
	int marks[99],i,a=0,total=0;
	float avg;
	printf("enter mathematics marks (0 to terminate):");
    for(i=0; ;i++)
	{
	scanf("%d",&marks[i]);
	if(marks[i]<=0)
	{
		break;
	}
	a++;
	total += marks[i];
    }
    avg=total/a;
    printf("average marks in mathematics:%2f\n",avg);
    getch();
	
}