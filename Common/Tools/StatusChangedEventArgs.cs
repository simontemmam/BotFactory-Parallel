﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Common.Tools
{
    public class StatusChangedEventArgs : EventArgs
    {
        public string NewStatus { get; set; }
        public StatusChangedEventArgs()
        {

        }
    }
}
