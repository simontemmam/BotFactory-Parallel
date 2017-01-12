﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Interface
{
    public interface IBaseUnit
    {
        string Name { get; set; }

        double Speed { get; set; }
        Coordinates CurrentPos { get; set; }
    }
}
