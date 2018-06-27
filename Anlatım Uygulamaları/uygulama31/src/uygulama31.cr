require "./uygulama31/*"

module Uygulama31

enum Takimlar

	Galatasaray
	Fenerbahce
	Besiktas = 8
	Trabzonspor

end

puts "Galatasaray Degeri"
puts Takimlar::Galatasaray.value
puts "------------------------"
puts "Fenerbahce Degeri"
puts Takimlar::Fenerbahce.value
puts "------------------------"
puts "Besiktas Degeri"
puts Takimlar::Besiktas.value
puts "------------------------"
puts "Trabzonspor Degeri"
puts Takimlar::Trabzonspor.value
puts "------------------------"

end
