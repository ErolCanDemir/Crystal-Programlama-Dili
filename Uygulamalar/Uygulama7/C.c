#include <stdio.h>
#include <stdlib.h>
int main()
{
	int vize = 80;
	int final = 70;
	int ortalama = (vize * 40 / 100) + (final * 60 / 100);
	if(ortalama<40)
	{
		printf("FF - Kaldý\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 40 && ortalama < 55)
	{
		printf("DD - Kaldý\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 55 && ortalama < 59)
	{
		printf("DC - Kaldý\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 59 && ortalama < 69)
	{
		printf("CC - Gecti\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 69 && ortalama < 75)
	{
		printf("CB - Gecti\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 75 && ortalama < 84)
	{
		printf("BB - Gecti\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 84 && ortalama < 90)
	{
		printf("BA - Gecti\nOrtalama :%d \n", ortalama );
	}
	else if(ortalama > 90 && ortalama < 101)
	{
		printf("AA - Gecti\nOrtalama :%d \n", ortalama );
	}
	else
	{
		printf("Gecerli bir not deðeri bulunamadý...");
	}
	
}
