using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WebProtoType
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string url1 = "http://www.IntelliTect.com";
            string url2 = "http://www.google.com";
            string url3 = "http://www.walla.com";

            WebInfoFactory wiFactory = new WebInfoFactory();

            Console.Write(url1 + " Size :");
            WebInfo wi1 = wiFactory.CreateWebInfo(url1);
            Console.WriteLine("Timestamp : " + wi1.TimeStamp);

            Console.Write(url2 + " Size :");
            WebInfo wi2 = wiFactory.CreateWebInfo(url2);
            Console.WriteLine("Timestamp : " + wi2.TimeStamp);

            Console.Write(url3 + " Size :");
            WebInfo wi3 = wiFactory.CreateWebInfo(url3);
            Console.WriteLine("Timestamp : " + wi3.TimeStamp);


        }
    }
}
