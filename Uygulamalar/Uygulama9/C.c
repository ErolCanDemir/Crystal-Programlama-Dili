#include <stdio.h>
int main()
{
	int dizi[5] = {1,2,4,3,5};
	int i = 0;
	int j = 0;
	printf("Ilk Hali\n");
	printf("-----------------------\n");
	while (i<5)
	{
		printf("%d\t",dizi[i]);
		i++;
	}
	int gecici = 0;
	gecici = dizi[2];
	dizi[2] = dizi[3];
	dizi[3] = gecici;
	printf("\n");
	printf("Yer Degismis Hali\n");
	printf("-----------------------\n");
	while (j<5)
	{           
		printf("%d\t",dizi[j]);
		j++;
	}
}
