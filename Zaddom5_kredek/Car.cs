using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddom5_kredek
{
    class Car : Vehicle
    {
        private string kindofcar;
        private Gearbox gearbox;

        public Car()
        {
            kindofcar = "SUV";
            gearbox = new Gearbox("maunal");
        }
       
        public Car(int numberofseats, string color, int manufactureyear, string carmake, string kindofcar, Gearbox gearbox)
        {
            this.numberofseats = numberofseats;
            this.color = color;
            this.manufactureyear = manufactureyear;
            this.carmake = carmake;
            this.kindofcar = kindofcar;
            this.gearbox = gearbox;

        }

        override public string GetCarmake()
        {
            Console.WriteLine("Printing car make: ");
            return this.carmake;
        }

        public void SetKindofcar(string kindofcar)
        {
            this.kindofcar = kindofcar;
        }

        public string GetKindofcar()
        {
            return this.kindofcar;
        }

        public void SetGearbox(Gearbox gearbox)
        {
            this.gearbox = gearbox;
        }

        public Gearbox GetGearbox()
        {
            return this.gearbox;
        }
    }
}
