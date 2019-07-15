using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    public class InfoHandler : LoggerHandlerBase
    {
        public override void Handle(int logLvl, string logMsg)
        {
            if (logLvl == 3)
            {
                Console.WriteLine("Info : " + logMsg);
                return;
            }

            if (next != null)
            {
                next.Handle(logLvl, logMsg);
            }
        }
    }
}
