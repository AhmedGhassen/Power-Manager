using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerManager.Models
{
    class FeedBack
    {
        public string id { set; get; }
        public string username { get; set; }
        public int stars { get; set; }
        public string description { get; set; }
    }
}
