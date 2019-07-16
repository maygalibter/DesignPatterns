using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class OracleTemplateBase : TemplateQueryRunner
    {
        protected override void CreateDBConnection()
        {
            Console.WriteLine("Creating oracle connection ... ");
        }
        protected override void OpenDBConnection()
        {
            Console.WriteLine("Opening oracle connection ... ");
        }
        protected override void CloseDBConnection()
        {
            Console.WriteLine("Closing oracle connection ... ");
        }
    }
}
