using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddom5_kredek
{
    abstract class Vehicle
    {
        protected int numberofseats;
        protected string color;
        protected int manufactureyear;
        protected string carmake;

        public Vehicle()
        {
            numberofseats = 5;
            color = "red";
            manufactureyear = 2010;
            carmake = "Toyota";

        }

        public Vehicle(int numberofseats, string color, int manufactureyear, string carmake)
        {
            this.numberofseats = numberofseats;
            this.color = color;
            this.manufactureyear = manufactureyear;
            this.carmake = carmake;
        }

        public void SetNumberofseats(int numberofseats)
        {
            this.numberofseats = numberofseats;
        }

        public int GetNumberofseats()
        {
            return this.numberofseats;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetManufactureyear( int manufactureyear)
        {
            this.manufactureyear = manufactureyear;
        }

        public int GetManufactureyear()
        {
            return this.manufactureyear;
        }

        public void SetCarmake(string carmake)
        {
            this.carmake = carmake;
        }

        public virtual string GetCarmake()
        {
            return this.carmake;
        }

        public string ReturnString()
        {
            string resultString = String.Empty;

            resultString += numberofseats;
            resultString += "\n";
            resultString += color;
            resultString += "\n";
            resultString += manufactureyear;
            resultString += "\n";
            resultString += carmake;
            resultString += "\n";

            return resultString;
        }
    }
}
