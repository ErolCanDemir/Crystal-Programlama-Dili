require "./uygulama32/*"

module Uygulama32

enum Programlama_Dilleri

	C # 0 tam sayı değerine sahip
	Java # 1 tam sayı değerine sahip
	Phyton # 2 tam sayı değerine sahip
	Assembly #3 tam sayı değerine sahip

end

puts "-------------------------------"
puts Programlama_Dilleri.new(0)
puts Programlama_Dilleri.new(1)
puts Programlama_Dilleri.new(2)
puts Programlama_Dilleri.new(3)
puts "-------------------------------"

end
