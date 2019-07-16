using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oracle
            new OracleSelectAllQuery().Run();

            Console.WriteLine();

            new OracleUpdateQuery().Run();

            Console.WriteLine();

            // Mongo
            new MongoInsertQuery().Run();

            Console.WriteLine();

            new MongoGetQuery().Run();

            Console.WriteLine();

            new MongoDeleteQuery().Run();
        }
    }
}
