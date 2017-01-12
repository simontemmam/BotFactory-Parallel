using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;

namespace BotFactory.Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {
        public string Name { get; set; }
        public Type Model { get; set; }
        public Coordinates ParkingPos { get; set; }
        public Coordinates WorkingPos { get; set; }
        public Queue<FactoryQueueElement> Queue { get; set; }
        public FactoryQueueElement(Type model, string name, Coordinates parkingPos, Coordinates workingPos)
        {
            Model = model;
            Name = name;
            ParkingPos = parkingPos;
            WorkingPos = workingPos;
        }
    }
}
