 #include<stdio.h>
 #include<conio.h>
 void fun();
 void main()
 {
    fun();
 }
 // no return type no argument
 void fun()
 {
    int x1,x2;
    printf("enter ywo number\n");
	scanf("%d%d",&x1,&x2);
    if(x1<x2)
   {
    printf("%d is smaller",x1);
   }
	else
	{
	printf("%d is smaller",x2);
	}
 }