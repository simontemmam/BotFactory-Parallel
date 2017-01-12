using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Common.Tools
{
    public class FactoryProgressEventArgs : EventArgs, IFactoryProgressEventArgs
    {
        public object returnUnit { get; set; }
        public FactoryProgressEventArgs()
        {

        }
    }
}
