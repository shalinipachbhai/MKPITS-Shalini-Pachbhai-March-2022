#include<stdio.h>
#include<conio.h>
void main()
{
	int i;
	char name[10];
	printf("enter any name");
	
	scanf("%s",&name);
	for(i=0;i<=10;i++)
	{
		printf("%c",name[i]);
		
	}
	getch();
}