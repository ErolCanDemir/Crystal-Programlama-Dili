require "./uygulama22/*"

module Uygulama22

class araba

property motor_gucu
getter arac_adi : String

def initialize(@arac_adi)
	motor_gucu = 2000
end

end

araba1 = araba.new "BMW"

BMW.motorgucu = 5000

end
