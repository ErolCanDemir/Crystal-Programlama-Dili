#include <stdio.h>
#include <stdlib.h>
int main()
{
	int i=1;
	while(i <= 100)
	{
		if( i % 2 == 0 && i % 7 == 0 )
		{
			printf("%d\n" , i);
		}
		i++;
	}
	return 0;
}
