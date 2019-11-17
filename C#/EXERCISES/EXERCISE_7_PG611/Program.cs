using System;


namespace OOP_EXERCISE{
    class Program{
        static void GSMTest(){
            BatteryType x = BatteryType.Graphene;
            Mobile_ph phone0 = new Mobile_ph("N400", "NOKIA", "ALEJANDRO", 400, "ERS456", 6535, 22, "6.5\"","BLUE", x );    

            BatteryType y = BatteryType.NiCd;
            Mobile_ph phone1 = new Mobile_ph("G4", "LG", "ALEJANDRO", 400, "ADM324", 5677, 22, "6.5\"","RED", y);

            BatteryType z = BatteryType.LiIon;
            Mobile_ph phone2 = new Mobile_ph("S10", "SAMSUNG", "DANIEL", 800, "ASR432", 5412, 22, "6.5\"","GREEN", z );

        }
        static void Main(string[] args){



        
          
        
        }
    }
}
