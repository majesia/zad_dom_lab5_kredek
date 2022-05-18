using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddom5_kredek
{
    class Bus : Vehicle
    {
        public Bus(int numberofseats, string color, int manufactureyear, string carmake)
        {
            this.numberofseats = numberofseats;
            this.color = color;
            this.manufactureyear = manufactureyear;
            this.carmake = carmake;
        }

        public void Delays()
        {
            Console.WriteLine("Przepraszamy za opoznienia");
        }
    }

}
