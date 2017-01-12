using BotFactory.Common.Tools;
using BotFactory.Interface;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IWorkingUnit : IBaseUnit, IBuildableUnit, IReportingUnit
    {
        Coordinates ParkingPos { get; set; }
        Coordinates WorkingPos { get; set; }
        bool IsWorking { get; set; }
        Task<bool> WorkBegins();
        Task<bool> WorkEnds();
    }
}
