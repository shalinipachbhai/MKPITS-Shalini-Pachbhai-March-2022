#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{

	char name1[10]={"shalini"};
	char name2[10]={"maya"};
	if(strcmp(name1,name2)==0)
	{
		printf("string1 name1 string2 name2 are same");
	}
	else
	{
		printf("string1 name1 string2 name2 are not same");
	}
	
	getch();
}