require "./uygulama27/*"

module Uygulama27

#Include anahtar kelimesi ile modül tanıtma...

Module Kalem_ucu

	def Uc_boyutu

		uc.boyut

	end

end

class Kalem

Include Kalem_ucu

	def kalem
	
		[0.5 , 0.7 , 1.0 ]

	end

end

kalem = Kalem.new
kalem.boyut 

end
