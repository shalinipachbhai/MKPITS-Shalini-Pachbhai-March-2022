 #include<stdio.h>
 #include<conio.h>
 int fun(int y1, int y2);
 void main()
 {
    int x1,x2,s;
    printf("enter ywo number\n");
	scanf("%d%d",&x1,&x2);
    s=fun(x1,x2);
    if(s==0)
    {
    printf("%d is smaller",x1);
	}
	else
	{
	printf("%d is smaller",x2);
	}
 }
 // return type with argument
 int fun(int y1, int y2)
 {
   
    if(y1<y2)
   {
    return 0;
   }
	else                  //flag principle 0 or 1 use
	{
	return 1;
	}
 }