#include<stdio.h>
#include<conio.h>
void main()
{
	int pass,p;
	while(p!=0)
	{
		printf("enter the password");
		scanf("%d",&pass);
		if(pass==1234)
		{
			printf("correct password\n",pass);
			p=0;
		}
		else
		{
			printf("wrong password\n");
		}
	}
	printf("\n");
}