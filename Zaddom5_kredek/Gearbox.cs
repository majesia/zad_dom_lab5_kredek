using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddom5_kredek
{
    class Gearbox
    {
        private string type;

        public Gearbox(string _type)
        {
            type = _type;
        }

        public string GetGearbox()
        {
            return type;
        }
    }
}
