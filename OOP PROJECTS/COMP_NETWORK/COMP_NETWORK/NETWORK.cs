//Project Computer v.09
////Inheritance

using System;
using System.Collections.Generic;

namespace OOP_in_Csharp{
    class Program{

        public static void Main(string[] args){

            List<Computer> network = new List<Computer>();

            //Creating the objects 

            GraphicSystem iota = new GraphicSystem("10.0.0.9", "Lenovo", "Linux", false, "BLENDER");
            Server omega = new Server("10.0.0.10", "Dell", "Linux", false, "WEB Server");
            Computer alfa = new Computer("10.0.0.11", "Dell", "Windows", false);
            Computer beta = new Computer("10.0.0.12", "Lenovo", "Linux", false);
            Computer gamma = new Computer("10.0.0.15", "HP", "Windows", false);
            Computer delta = new Computer("10.0.0.16", "Dell", "Windows", false);


            //Adding objects Computer to the list network
            network.Add(iota);
            network.Add(omega);
            network.Add(alfa);
            network.Add(beta);
            network.Add(gamma);
            network.Add(delta);

            int compsInNetwork = Computer.CountComps();
            Console.WriteLine("We have {0} computers in our network.\n", compsInNetwork);

            //"Swithing on the computers"
            for (int i = 0; i < network.Count; i++){
                network[i].StartComputer();
            }

            Console.WriteLine("--------------------------------------------------------------------\n");

            Console.WriteLine("We have {0} computers in our network that is switched ON\n", Computer.CountSwitched());


            //iterating over the list network   


            foreach (Computer comp in network){
                if (comp.SwitchedOn){

                    //Console.WriteLine(comp.GetType());

                    Console.Write("{0}\t{1}\t\t{2}\t", comp.Ipaddress, comp.OperatingSystem, comp.Make);
                    Type type = comp.GetType();
                    string stringType = type.ToString();
                    int pos = stringType.IndexOf('.');
                    Console.Write(stringType.Substring(pos + 1, 4));

                    if (stringType.Substring(pos + 1, 4) == "Serv"){
                        System.Console.WriteLine("\t{0}", omega.Destination);

                    }else if (stringType.Substring(pos + 1, 4) == "Grap"){
                        System.Console.WriteLine("\t{0}", iota.GraphicOS);

                    }else
                        Console.WriteLine();

                    //Console.WriteLine(comp.GetType());
                }
            }

            Console.WriteLine("--------------------------------------------------------------------\n");
            omega.ShutDown();
            //beta.ShutDown();
            Console.WriteLine("\nWe have {0} computers in our network that is switched ON\n", Computer.CountSwitched());

            //iterating over the list network       
            foreach (Computer comp in network)
            {
                if (comp.SwitchedOn)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}", comp.Ipaddress, comp.OperatingSystem, comp.Make);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------\n");


            //Test of ping to other computers

            Random rnd = new Random();
            double answer;

            Computer myComp = alfa;
            String pingTo = "10.0.0.12";

            bool found = false;
            foreach (Computer comp in network)
            //this can be encapsulated
            {
                if ((pingTo == comp.Ipaddress) && (comp.SwitchedOn == true))
                {
                    found = true;
                    break;
                }
            } // the end of the loop


            if (found)

            {
                for (int i = 5; i < 15; i++)
                {
                    answer = (float)(rnd.Next(1, 100)) / 100;
                    Console.WriteLine("64 bytes from {0} icmp_seq={1} ttl=64 time={2} ms", myComp.Ipaddress, i.ToString(), answer.ToString());
                }
            }
            else
            {
                Console.WriteLine("Adress {0} not found !!! ", pingTo);
            }
            //the end of pinging


        }
    }
}
