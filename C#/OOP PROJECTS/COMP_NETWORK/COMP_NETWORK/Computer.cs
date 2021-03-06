﻿using System;


namespace OOP_in_Csharp{
    public class Computer{

        public Computer(string ip, string make, string osystem, bool switched){
            this.Ipaddress = ip;
            this.Make = make;
            this.OperatingSystem = osystem;
            this.SwitchedOn = switched;

            compCounter++;
        }

        public Computer()
        {
            compCounter++;
        }

        // private member variables
        private string _ipadress;
        private bool _switchedOn;
        private string _make;
        private string _operatingSystem;

        private static int compCounter = 0; //counts comps in the network
        private static int switchedCounter = 0; //counts comps that are switched

        public static int CountComps()
        {
            return compCounter;
        }

        public static int CountSwitched()
        {
            return switchedCounter;
        }

        public void StartComputer()
        {
            this.SwitchedOn = true;
            switchedCounter++;
            Console.WriteLine("The comp {0} is starting ...", this.Ipaddress);
        }

        public void ShutDown()
        {
            this.SwitchedOn = false;
            switchedCounter--;
            Console.WriteLine("The comp {0} is shuting down !!!", this.Ipaddress);
        }

        public string IsSwitched()
        {
            if (this.SwitchedOn)
            {
                return "switched ON";
            }
            else
            {
                return "switched OFF";
            }
        }

        // public properties
        public string Ipaddress
        {
            get { return _ipadress; }
            set { _ipadress = value; }
        }
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string OperatingSystem
        {
            get { return _operatingSystem; }
            set { _operatingSystem = value; }
        }
        public bool SwitchedOn
        {
            get { return _switchedOn; }
            set { _switchedOn = value; }
        }



    }

public class Server : Computer
    {
        public Server (string ip, string make, string osystem, bool switched, string dest) : base(ip, make, osystem, switched)
        {           
            this.Destination = dest;

        }

        // private member variables
        protected string _destination;

        // public properties
        public string Destination
        {
            get { return _destination;  }
            set { _destination = value; }
        }


    }
    
    //--------------------------------
    public class GraphicSystem : Computer{
        public GraphicSystem (string ip, string make, string osystem, bool switched, string graphicOS) 
            : base(ip, make, osystem, switched){            
                    
                this.GraphicOS = graphicOS;
        }

        // protected member variables
        protected string _graphicOS;
        
        // public properties
        public string GraphicOS{
            get { return _graphicOS ;  }
            set { _graphicOS = value; }
        }
    }
    
    //--------------------------------


}

/*

csc -t:library  Computer.cs
mcs -r:Computer.dll NETWORK.cs

*/