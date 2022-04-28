#include<stdio.h>
void main()
{
	int i=0;
	printf("even number between 1-50\n");
	while(i<=50)
	{
		if(i%2==0)
		{
			printf("%d",i);
			
		}
		i++;
	}
}