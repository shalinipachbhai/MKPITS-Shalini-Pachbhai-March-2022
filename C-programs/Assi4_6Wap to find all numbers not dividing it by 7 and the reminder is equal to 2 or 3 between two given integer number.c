#include<stdio.h>
#include<conio.h>
void main()
{
 int n1,n2,temp,i;
 printf("enter two number\n");
 scanf("%d%d",&n1,&n2);
 printf("number which is divided by7\n");
 if(n1>n2)
 {
 	temp=n1;
 	n1=n2;
 	n2=temp;
 }	
 i=n1;
 while(i<=n2)
 {
if(i%7==2||i%7==3)
{
	printf("%d\n",i);
}
i++;
 }

}