i = 0 ;
j = 0 ;
gecici = 0;
dizi = [1,2,4,3,5];
puts "İlk Hali";
puts "---------------------------------------";
while i<5
	puts dizi[i];
	i+=1;
end
gecici = dizi[2];
dizi[2] = dizi[3];
dizi[3] = gecici;
puts "Sıralanmış Hali";
puts "---------------------------------------";
while j<5
        puts dizi[j];
        j+=1;
end

