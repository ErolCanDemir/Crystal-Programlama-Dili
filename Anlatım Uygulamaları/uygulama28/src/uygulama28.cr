require "./uygulama28/*"

module Uygulama28

#Extend anahtar kelimesi ile modül tanıtma...

Module Kalem_ucu

	def Uc_boyutu

		uc.boyut

	end

end

class Kalem

Extend Kalem_ucu

	def kalem
	
		[0.5 , 0.7 , 1.0 ]

	end

end

kalem = Kalem.new
kalem.boyut 

end
end
