using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public abstract class WorkingUnit : BaseUnit, IWorkingUnit, ITestingUnit
    {
        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }
        public WorkingUnit(string name, double bt, double speed)
            : base(name, bt, speed)
        {

        }
        public async virtual Task<bool> WorkBegins()
        {
            await Move(WorkingPos);
            OnStatusChanged(new StatusChangedEventArgs { NewStatus = "Working" });
            return true;
        }
        public async virtual Task<bool> WorkEnds()
        {
            await Move(ParkingPos);
            OnStatusChanged(new StatusChangedEventArgs { NewStatus = "Parking" });
            return true;
        }

    }
}
