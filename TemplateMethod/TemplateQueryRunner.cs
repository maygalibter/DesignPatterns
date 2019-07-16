using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class TemplateQueryRunner
    {

        protected abstract void CreateDBConnection();
        protected abstract void OpenDBConnection();
        protected abstract void ExecuteQuery();
        protected abstract void CloseDBConnection();


        public void Run()
        {
            CreateDBConnection();
            OpenDBConnection();
            ExecuteQuery();
            CloseDBConnection();
        }
    }
}
