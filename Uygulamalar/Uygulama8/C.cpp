#include <stdio.h>
#include <stdlib.h>
int main()
{
	int i = 0;
	int j = 0;
	int k = 0;
	int l = 0;
	int no[5] = {1,2,3,4,5};
	char ad[5] = {'Erol','Can','Mert','Esad','Tolga'};
	char soyad[5] = {'Demir','Alan','Cetin','Topkara','Tas'};
	char sehir[5] = {'Ankara','Istanbul','Izmir','Konya','Ankara'};
	char semt[5] = {'Sincan','Pendik','Kasiyaka','Selcuklu','Kecioren'};
	printf("Tum Personellerin Listesi\n");
	printf("-----------------------------------\n");
	while(i<5)
	{
		printf("%d\n",no[i]);
		printf("%c\n",ad[i]);
		printf("%c\n",soyad[i]);
		printf("%c\n",sehir[i]);
		printf("%c\n",semt[i]);
		printf("-----------------------------------\n");
		i++;
	}
	printf("Numarasi 4 olan personel Listesi\n");
	printf("-----------------------------------\n");
	while(j<5)
	{
		if(no[j]==4)
		{
			printf("%d\n",no[i]);
			printf("%c\n",ad[i]);
			printf("%c\n",soyad[i]);
			printf("%c\n",sehir[i]);
			printf("%c\n",semt[i]);
			printf("-----------------------------------\n");
		}
		j++;
	}
	printf("Adi Esad olan personel Listesi\n");
	printf("-----------------------------------\n");
	while(k<5)
	{
		if(ad[k]=='Esad')
		{
			printf("%d\n",no[i]);
			printf("%c\n",ad[i]);
			printf("%c\n",soyad[i]);
			printf("%c\n",sehir[i]);
			printf("%c\n",semt[i]);
			printf("-----------------------------------\n");
		}
		k++;
	}
	printf("Ankara'da oturan personel Listesi\n");
	printf("-----------------------------------\n");
	while(l<5)
	{
		if(sehir[l]=='Ankara')
		{
			printf("%d\n",no[i]);
			printf("%c\n",ad[i]);
			printf("%c\n",soyad[i]);
			printf("%c\n",sehir[i]);
			printf("%c\n",semt[i]);
			printf("-----------------------------------\n");
		}
		l++;
	}
	
}
