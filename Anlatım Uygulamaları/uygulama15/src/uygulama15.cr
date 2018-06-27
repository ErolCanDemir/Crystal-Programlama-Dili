require "./uygulama15/*"

module Uygulama15

sayi = 0 # sayi değişkeni tanımlandı.
sayac = 0 # Döngünün kaç kere döndüğünü bulmak için sayac değişkeni tanımlandı.
toplam = 0 #DÖngüde ki sayıları toplatmak için toplam değişkeni tanımlandı.
while sayi <=20 #sayi değişkeni 20 den küçük veya eşit olduğu sürece döngü dönsün
	toplam +=sayi # toplam = toplam + sayi her sayı değişkeniyle yeni toplam değişkeni toplatıldı.
	sayac +=1 # DÖngü döndüğü için sayac değişkeni arttırıldı.
	sayi+=1 # sayi değişkeni arttırıldı.
	puts "Yeni sayı:",sayi # Döngüye her girildiğinde sayının değeri yazdırıldı.
	puts "Yeni toplam:",toplam # Döngüye her girildiğinde toplamın değeri yazdırıldı.
end # While döngüsü bitirildi.
ortalama = toplam / sayac 
puts "0'dan 20'ye kadar sayıların aritmetik ortalaması:",ortalama
end
