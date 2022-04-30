#include<stdio.h>
#include<conio.h>
void main()
{
 int n1,n2,temp,sum=0,i;
 printf("enter two number\n");
 scanf("%d%d",&n1,&n2);
 if(n1>n2)
 {
 	temp=n1;
 	n1=n2;
 	n2=temp;
 }	
 i=n1;
 while(i<n2)
 {
if(i%17!=0)
{
	sum=sum+1;
}
i++;
 }
 printf("sum of all number not divisible by 17=%d",sum);
}