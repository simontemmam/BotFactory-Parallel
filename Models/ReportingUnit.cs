using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public abstract class ReportingUnit : BuildableUnit, IBuildableUnit
    {
        public string CurrentStatus { get; set; }
        public event UnitStatusChangedDelegate UnitStatusChanged;
        public void OnStatusChanged(StatusChangedEventArgs source)
        {
            
            if (CurrentStatus != source.NewStatus)
            {
               CurrentStatus = source.NewStatus;
            }
            else
            {
                source.NewStatus = "Already " + CurrentStatus;
            }
            UnitStatusChanged?.Invoke(this, source);
        }
    }
}
