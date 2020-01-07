using System;

namespace OOP_EXERCISE{
    class GSM_Test{
        static void GSMTest(){
            BatteryType x = BatteryType.Graphene;
            Mobile_ph phone0 = new Mobile_ph("N400", "NOKIA", "ALEJANDRO", 400, "ERS456", 6535, 22, "6.5\"","BLUE", x );    

            BatteryType y = BatteryType.NiCd;
            Mobile_ph phone1 = new Mobile_ph("G4", "LG", "ALEJANDRO", 400, "ADM324", 5677, 22, "6.5\"","RED", y);

            BatteryType z = BatteryType.LiIon;
            Mobile_ph phone2 = new Mobile_ph("S10", "SAMSUNG", "DANIEL", 800, "ASR432", 5412, 22, "6.5\"","GREEN", z );

            Console.WriteLine(phone0.Manufacturer+" "+ phone0.Model+" "+ phone0.Owner+" "+ phone0.Price );
            Console.WriteLine(phone1.Manufacturer+" "+ phone1.Model+" "+ phone1.Owner+" "+ phone1.Price );
            Console.WriteLine(phone2.Manufacturer+" "+ phone2.Model+" "+ phone2.Owner+" "+ phone2.Price );

        }

        static void GSMCallHistoryTest(){
            double max_call = 0;

            BatteryType x = BatteryType.Graphene;
            Mobile_ph phone0 = new Mobile_ph("N400", "NOKIA", "ALEJANDRO", 400, "ERS456", 6535, 22, "6.5\"","BLUE", x );

            TimeSpan time_call = new TimeSpan(16, 14, 18);
            DateTime date = DateTime.Now;
            TimeSpan drtn_call = new TimeSpan(1, 20, 0);

            Call call0 = new Call(date, time_call, drtn_call);
            phone0.AddCall(call0);

            //2ond Call
            time_call = new TimeSpan(11, 12, 13);
            date = DateTime.Now;
            drtn_call = new TimeSpan(2, 0, 0);
            call0 = new Call(date, time_call, drtn_call);
            phone0.AddCall(call0);
            
            //3rd Call
            time_call = new TimeSpan(12, 20, 5);
            date = DateTime.Now;
            drtn_call = new TimeSpan(3, 40, 5);
            call0 = new Call(date, time_call, drtn_call);
            phone0.AddCall(call0);

            //list ph calls and calculate price of all
            phone0.Ph_calls();

            foreach (Call elem in phone0.CallHistory)
                if (elem.CallDrtn.TotalMinutes > max_call)    
                    max_call = elem.CallDrtn.TotalMinutes;

            
            Console.WriteLine("\nPRICE FOR ALL CALLS: {0}", phone0.Cost_all_calls().ToString("0.##"));
            Console.WriteLine("\nLONGEST CALL DURATION IS: {0}", max_call.ToString("0.#"));   
            
            //find the one with largest duration and remove it
            Call found = phone0.CallHistory.Find(x => x.CallDrtn.TotalMinutes == max_call);            
            if (found != null) 
                phone0.CallHistory.Remove(found);

            //list another time and calculate price of all 
            phone0.Ph_calls();
            Console.WriteLine("\nPRICE FOR ALL CALLS: {0}", phone0.Cost_all_calls().ToString("0.##"));

            //remove all ph calls
            phone0.Rmv_ph_calls();
            phone0.Ph_calls();

        }
        
        static void Main(string[] args){
            GSMTest();
            Console.WriteLine("\n**************************************************");
            GSMCallHistoryTest();
        }
    }
}
