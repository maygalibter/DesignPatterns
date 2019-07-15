using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProtoType
{
    public class WebInfo : IProtoType<WebInfo>
    {
        public DateTime TimeStamp  { get; set; }

        public string Size { get; set; }

        public string Url { get; set; }

        public WebInfo(DateTime timeStamp, string size, string url)
        {
            this.TimeStamp = timeStamp;
            this.Size = size;
            this.Url = url;
        }
        public WebInfo clone()
        {
            return new WebInfo(TimeStamp, Size, Url);
        }
    }
}
