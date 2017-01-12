using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    class WALLE : WorkingUnit
    {
        public  WALLE(string NameRobot):base(NameRobot, 4, 2)
            {
            WorkingPos = new Common.Tools.Coordinates(8, 8);
            ParkingPos = new Common.Tools.Coordinates(3, 3);
            Model = "WALLE";
        }
    }
}
