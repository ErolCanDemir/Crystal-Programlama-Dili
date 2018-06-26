#include <stdio.h>
#include <stdlib.h>
int main()
{
	int dizi[5] = {1 , 4 , 20 , 10 , 50};
	int i = 1;
	int j = 1;
	int max , min ;
	while (i < 5)
	{
		max = dizi[0];
		if(dizi[i] > max)
		{
			max = dizi[i];
		}
		i++;
	}
	printf("Dizinin maximum degeri = %d\n" , max );
	printf("-----------------------------------------\n");
	while (j < 5)
	{
		min = dizi[0];
		if(dizi[j] < min)
		{
			min = dizi[j];
		}
		j++;
	}
	printf("Dizinin minimum degeri = %d\n" , min);
	return 0;
}
