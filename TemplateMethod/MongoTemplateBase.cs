using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class MongoTemplateBase : TemplateQueryRunner
    {
        protected override void CreateDBConnection()
        {
            Console.WriteLine("Creating mongo connection ... ");
        }
        protected override void OpenDBConnection()
        {
            Console.WriteLine("Opening mongo connection ... ");
        }
        protected override void CloseDBConnection()
        {
            Console.WriteLine("Closing mongo connection ... ");
        }
    }
}
