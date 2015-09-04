#include <iostream>
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
//đánh dấu đã sửa
typedef struct DaThuc
{
	float heso;
	int somu;
};
typedef struct node
{
	DaThuc info;
	node *next;
};
typedef node *dt, *dt1, *dt2;
void InsertAtFirst(dt &dathuc, DaThuc value)
{
	node *temp;
	temp=(node*)malloc(sizeof(node));
	temp->info=value;
	temp->next=dathuc;
	dathuc=temp;
}
void InsertAtLast(dt &dathuc, DaThuc value)
{
	if(dathuc==NULL) InsertAtFirst(dathuc,value);
	else
	{
		node *temp1, *temp2;
		temp2=dathuc;
		while(temp2->next!=NULL) temp2=temp2->next;
		temp1=(node*)malloc(sizeof(node));
		temp1->info=value;
		temp1->next=NULL;
		temp2->next=temp1;
	}
}
int InsertAtPos(dt &dathuc, DaThuc value, int pos)
{
	if(dathuc==NULL) InsertAtFirst(dathuc,value);
	else
	{
		node *temp1, *temp2;
		int i;
		while(i<pos)
		{
			temp2=dathuc;
			if(temp2->next==NULL) return -1;
			else
			{
				temp2=temp2->next;
				i++;
			}
		}
		temp1=(node*)malloc(sizeof(node));
		temp1->info=value;
		temp1->next=temp2->next;
		temp2->next=temp1;
	}
}
void Print(dt dathuc)
{
	while(dathuc!=NULL)
	{
		printf("%d ",dathuc->info);
		dathuc=dathuc->next;
	}
}
int main()
{
	//t thu file lan 1
	dt1 dathuc1=NULL;
	dt2 dathuc2=NULL;
	InsertAtFirst(dathuc1,5);
	InsertAtLast(dathuc1,6);
	InsertAtPos(dathuc1,7,2);
	node *temp;
	temp=(node*)malloc(sizeof(node));
	scanf("%f",&temp->info.heso);
	printf("%f",temp->info.heso);
}
