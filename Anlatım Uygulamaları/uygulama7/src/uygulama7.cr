require "./uygulama7/*"

module Uygulama7

okul_numarasi = 163311036
sifre = "abcd"

if okul_numarasi == 163311036	&&	sifre == "abc"
puts "Okul numarası ve şifre doğru"

elsif okul_numarasi == 163311036	&& 	sifre != "abc"
puts "OKul numarasi doğru fakat şifresi yanlış"

elsif okul_numarasi != 163311036	&& 	sifre == "abc"
puts "Okul numarasi yanlış fakat şifre doğru"

else
puts "Okul numarasi ve şifre yanlış"

end

end
