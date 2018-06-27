dizi = [1,4,20,10,50];
i = 1;
j = 1;
while i < 5
	max = dizi[0];
	if dizi[i] > max
		max = dizi[i];
	end
	i+=1;
end
puts "Dizinin Maksimum Değeri:"; 
puts max ;
puts "------------------------------------------"
while j < 5
	min = dizi[0];
	if min > dizi[j]
		min = dizi[j];
	end
	j+=1;
end
puts "Dizinin Minimum Değeri:"; 
puts  min;
