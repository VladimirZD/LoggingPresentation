using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingTipsTricks
{
    
    class Helpers
    {
        public static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
