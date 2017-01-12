using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Interface
{
    public interface IReportingUnit
    {
        event UnitStatusChangedDelegate UnitStatusChanged;
    }
    public delegate void UnitStatusChangedDelegate(object origin, StatusChangedEventArgs e);
}
