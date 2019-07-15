using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    public abstract class LoggerHandlerBase
    {
        protected LoggerHandlerBase next;
        public abstract void Handle(int logLvl, string logMsg);

        public void SetNext(LoggerHandlerBase next)
        {
            this.next = next;
        }
    }
}
