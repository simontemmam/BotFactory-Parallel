using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    class T800 : WorkingUnit
    {
        public  T800(string NameRobot):base(NameRobot, 3, 10)
            {
            WorkingPos = new Common.Tools.Coordinates(7, 7);
            ParkingPos = new Common.Tools.Coordinates(2, 2);
            Model = "T800";
        }
    }
}
