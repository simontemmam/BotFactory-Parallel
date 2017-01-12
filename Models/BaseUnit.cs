using BotFactory.Common.Tools;
using BotFactory.Interface;
using System.Threading.Tasks;
using System;


namespace BotFactory.Models
{
    public abstract class BaseUnit : ReportingUnit , IBaseUnit 
        {
        public BaseUnit(string name = "Robot", double bt=5.0, double speed=1.0)
        {
            Name = name;
            Speed = speed;

            CurrentPos = new Coordinates(0.0, 0.0);
        }
        public async Task<bool> Move(Coordinates destination)
        {
            Vector vect = Vector.FromCoordinates(CurrentPos, destination);
            if(!Equals(CurrentPos, destination))
            {
                double timeToMove = vect.Length() / Speed;
                OnStatusChanged(new StatusChangedEventArgs { NewStatus = "Moving" });
                await Task.Delay(Convert.ToInt32(timeToMove)*1000);
                CurrentPos = destination;
                return true;
            }
            return false;

        }
        public string Name { get; set; }

        public double Speed { get; set; }
        public Coordinates CurrentPos { get; set; }
    }
     
}
