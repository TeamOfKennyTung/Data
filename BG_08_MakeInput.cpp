#include "stdio.h"
#include "conio.h"
#include "stdlib.h"
#include <time.h>
void QuickSort(int a[],int left, int right)
{
	int i,j,x,tg;
	i=left;
	j=right;
	x=(left+right)/2;
	if(i>=j) return;//khong phan hoach neu day chi co 1 phan tu
	do
	{
		while(a[i]<a[x]) i++;
		while(a[j]>a[x]) j--;
		if(i<=j)
		{
			tg=a[i];
			a[i]=a[j];
			a[j]=tg;
			i++;j--;
		}
	}while(i<j);
	if(left<j) QuickSort(a,left,j);
	if(i<right) QuickSort(a,i,right);
}
//DAi ca luan da vao day
void BubbleSort(int a[])
{
	for(int i=99999;i<200000;i++)
	for(int j=200000-1;j>i;j--)
	{
		if(a[j]<a[j-1])
		{
			int tg=a[j];
			a[j]=a[j-1];
			a[j-1]=tg;
		}
	}	
}


int main()
{
	FILE *f,*g;
//	g=fopen("input1.in","wt");
	f=fopen("input2.in","wt");
	int a[300000];
//	int b[100000];
//	for(int i=0;i<100000;i++)
//	{
//		b[i]=rand()%1000;
//	}
	srand(time(NULL));
	for(int i=0; i<300000; i++)
	{
		a[i]=rand()%1000;
	}
	//BubbleSort(a);
	for(int i=0; i<300000; i++)
	fprintf(f,"%d ",a[i]);
	fclose(f);
//	for(int i=0;i<100000;i++)
//	fprintf(g,"%d ",b[i]);
//	fclose(g);
//	FILE *g;
//	g=fopen("input.txt","rt");
//	for(int i=100001; i<200002; i++)
//	{
//		fscanf(g,"%d",&a[i]);
//	}
//	for(int i=10000; i<200002; i++)
//	printf("%d ",a[i]);
	//I'm Luan's Father
}
