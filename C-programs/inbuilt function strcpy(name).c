#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{

	char name1[10]={"shalini"};
	 char name2[10]={"maya"};
	strcpy(name1,name2);
	printf("%s",name1);
	getch();
}