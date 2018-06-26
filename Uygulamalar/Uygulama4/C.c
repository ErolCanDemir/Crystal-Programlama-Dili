#include <stdio.h>
#include <stdlib.h>
int main()
{
	int i = 1;
	int j = 1;
	int karesi;
	while(i<20)
	{
		printf("%d\n" , i);
		i++;
	}
	printf("\n");
	printf("---------Kareleri----------\n");
	while(j<20)
	{
		karesi = j * j ;
		printf("%d\n" , karesi);
		j++;
	}
	return 0;
}

