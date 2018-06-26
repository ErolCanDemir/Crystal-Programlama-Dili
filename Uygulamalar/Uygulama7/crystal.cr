vize = 80 ;
final = 70;
ortalama = (vize * 40 / 100) + (final * 60 / 100);
if ortalama < 40
	puts "FF - Kaldı.";
	puts "Ortalama:";
	puts ortalama
elsif ortalama>40 && ortalama<55
	puts "DD -Kaldı";
	puts "Ortalama:";
	puts ortalama;
elsif ortalama>55 && ortalama<59
        puts "DC -Kaldı";
        puts "Ortalama:";
        puts ortalama;
elsif ortalama>59 && ortalama<69
        puts "CC -Geçti";
        puts "Ortalama:";
        puts ortalama;
elsif ortalama>69 && ortalama<75
        puts "CB - Geçti";
        puts "Ortalama:";
        puts ortalama;
elsif ortalama>75 && ortalama<84
        puts "BB - Geçti";
        puts "Ortalama:";
        puts ortalama;
elsif ortalama>84 && ortalama<90
        puts "BA - Geçti";
        puts "Ortalama:";
        puts ortalama;
elsif ortalama>90 && ortalama<101
        puts "AA - Geçti";
        puts "Ortalama:";
        puts ortalama;
else
	puts "Uygun bir not değeri bulunamadı...";
end


