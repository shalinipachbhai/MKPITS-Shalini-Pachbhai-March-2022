#include<stdio.h>
#include<conio.h>
void main()
{
	float n1,n2,n3,n4,max,min;
	printf("enter four real number\n");
	scanf("%f%f%f%f",&n1,&n2,&n3,&n4);
	if(n1>=n2 && n1>=n3 && n1>=n4)
	{
	
	max=n1;
    }
	else
	if(n2>=n1 && n2>=n3 && n2>=n4)
	{
	max=n2;
	}
	else if(n3>=n1&& n3>=n2 && n3>=n4)
	{
		max=n3;
	}
	else if(n4>=n1 &&  n4>=n2 && n4>n3)
	{
		max=n4;
	}
	if(n1<=n2&&n1<=n3&&n1<=n4)
	{
		min=n1;
	}
	else if(n2<=n1&&n2<=n3&&n2<=n4)
	{
		min=n2;
	}
	else if(n3<=n1&&n3<=n2&&n3<=n4)
	{
		min=n3;
	}
	else if(n4<=n1&&n4<=n2&&n4<=n3)
	{
		min=n4;
	}
	printf("difference is%f\n",max,min);
}