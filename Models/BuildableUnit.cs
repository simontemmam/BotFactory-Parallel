using System;
using System.Collections.Generic;
using BotFactory.Common.Tools;
using BotFactory.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public abstract class BuildableUnit : IBuildableUnit
    {
        public string Model { get; set; }
        public BuildableUnit(double bt=5.0)
        {
            BuildTime = bt;
        }
        public double BuildTime { get; set; }

    }
}
