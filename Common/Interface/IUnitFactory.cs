using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;

namespace BotFactory.Interface
{
    public interface IUnitFactory
    {
        TimeSpan QueueTime { get; set; }
        int QueueCapacity { get; }
        int StorageCapacity { get; }
        int QueueFreeSlots { get; }
        int StorageFreeSlots { get; }
        List<ITestingUnit> Storage { get; set; }
        Queue<IFactoryQueueElement> Queue { get; set; }
        bool AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos, Coordinates workingPos);
        void AddStorage(ITestingUnit BuiltUnity);
        void BuildWorkableUnit();
        void StartBuilding();

        event FactoryProgressDelegate FactoryProgress;
    }
    public delegate void FactoryProgressDelegate(object origin, FactoryProgressEventArgs f);
}
