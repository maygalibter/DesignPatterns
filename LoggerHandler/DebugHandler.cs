using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    public class DebugHandler : LoggerHandlerBase
    {
        public override void Handle(int logLvl, string logMsg)
        {
            if (logLvl == 4)
            {
                Console.WriteLine("Debug : " + logMsg);
                return;
            }

            if (next != null)
            {
                next.Handle(logLvl, logMsg);
            }
        }
    }
}
