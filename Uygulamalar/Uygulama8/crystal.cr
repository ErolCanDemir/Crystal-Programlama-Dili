no = [1,2,3,4,5];
ad = ["Erol","Can","Mert","Esad","Tolga"];
soyad = ["Demir","Alan","Çetin","Topkara","Taş"];
sehir = ["Ankara","İstanbul","İzmir","Konya","Ankara"];
semt = ["Sincan","Pendik","Karşıyaka","Selçuklu","Keçiören"];
i = 0;
j=0;
k=0;
l=0;
puts "Tüm Personellerin Listesi";
puts "---------------------------------------";
while i<5
	puts no[i];
	puts ad[i];
	puts soyad[i];
	puts sehir[i];
	puts semt[i];
	puts "---------------------------------------";
	i+=1;
end
puts "Numarası 4 olan personel bilgileri";
puts "--------------------------------------";
while j<5
	if no[j] == 4
		puts no[j];
		puts ad[j];
		puts soyad[j];
		puts sehir[j];
		puts semt[j];
		puts "---------------------------------------";
	end
	j+=1;
end
puts "Adı Esad olan personel bilgileri";
puts "---------------------------------------";
while k<5
	if ad[k] == "Esad"
		puts no[k];
                puts ad[k];
                puts soyad[k];
                puts sehir[k];
                puts semt[k];
		puts "---------------------------------------";
	end
	k+=1;
end
puts "Ankara'da oturan personel bilgileri";
puts "---------------------------------------";
while l<5
        if sehir[l] == "Ankara"
                puts no[l];
                puts ad[l];
                puts soyad[l];
                puts sehir[l];
                puts semt[l];
		puts "---------------------------------------";
        end
	l+=1;
end

