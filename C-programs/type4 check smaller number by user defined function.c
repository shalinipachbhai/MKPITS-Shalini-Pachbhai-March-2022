 #include<stdio.h>
 #include<conio.h>
 int fun();
 void main()
 {
    int s;
    if(s==0)
    {
    	printf("first number is smaller");
	}
	else
	{
	printf("second number is smaller");
	}
 }
 // return type no argument
 int fun()
 {
    int x1,x2;
    printf("enter ywo number\n");
	scanf("%d%d",&x1,&x2);
    if(x1<x2)
   {
    return 0;
   }
	else
	{
	return 1;
	}
 }