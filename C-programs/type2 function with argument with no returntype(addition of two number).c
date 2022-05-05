#include<stdio.h>
#include<conio.h>
void fun1();
void add(int x,int y);
void main()
{
	fun1();
}
void fun1()
{
	int a,b;
	printf("enter two number\n");
	scanf("%d%d",&a,&b);
	add(a,b);
}
void add(int x, int y)
{
	int res;
	res=x+y;
	printf("%d",res);
}