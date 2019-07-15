using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    public class FatalHandler : LoggerHandlerBase
    {
        public override void Handle(int logLvl, string logMsg)
        {
           if(logLvl == 1)
            {
                Console.WriteLine("Fatal : " + logMsg);
                return;
            }

            if (next != null)
            {
                next.Handle(logLvl, logMsg);
            }
        }
    }
}
