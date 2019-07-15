using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerHandlerBase fatalHandler1 = new FatalHandler();
            LoggerHandlerBase errorHandler1 = new ErrorHandler();
            LoggerHandlerBase infoHandler1 = new InfoHandler();
            LoggerHandlerBase debugHandler1 = new DebugHandler();

            LoggerHandlerBase logRoot1 = fatalHandler1;
            fatalHandler1.SetNext(errorHandler1);
            errorHandler1.SetNext(infoHandler1);
            infoHandler1.SetNext(debugHandler1);

            LoggerHandlerBase fatalHandler2 = new FatalHandler();
            LoggerHandlerBase errorHandler2 = new ErrorHandler();
            LoggerHandlerBase infoHandler2 = new InfoHandler();
            LoggerHandlerBase debugHandler2 = new DebugHandler();

            LoggerHandlerBase logRoot2 = debugHandler2;
            debugHandler2.SetNext(infoHandler2);
            infoHandler2.SetNext(errorHandler2);
            errorHandler2.SetNext(fatalHandler2);

            Console.WriteLine("*** Logger Handler ***\n");
            Console.WriteLine("First concatination : fatal -> error -> info -> debug");
            Console.WriteLine("======================================================");
            logRoot1.Handle(1, "System is going down!");
            logRoot1.Handle(2, "Error 400");
            logRoot1.Handle(3, "Alarm, don't have enough memory");
            logRoot1.Handle(4, "Debug info");

            Console.WriteLine("\n------------------------------------------------------\n");
            Console.WriteLine("Second concatination : debug -> info -> error -> fatal");
            Console.WriteLine("======================================================");
            logRoot2.Handle(1, "System is going down!");
            logRoot2.Handle(2, "Error 400");
            logRoot2.Handle(3, "Alarm, don't have enough memory");
            logRoot2.Handle(4, "Debug info");



        }
    }
}
