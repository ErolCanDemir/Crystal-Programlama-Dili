#include <stdio.h>
#include <stdlib.h>
int main()
{
	int sayi1 = 50 ;
	int sayi2 = 10 ;
	int toplam = sayi1 + sayi2;
	printf("Toplam = %d\n",toplam);
	printf("------------------------------\n");
	int fark = sayi1 - sayi2;
	printf("Fark = %d\n",fark);
	printf("------------------------------\n");
	int carpim = sayi1 * sayi2;
	printf("Carpimi = %d\n",carpim);
	printf("------------------------------\n");
	int bolum = sayi1 / sayi2;
	printf("Bolum = %d\n",bolum);
	return 0;
}
