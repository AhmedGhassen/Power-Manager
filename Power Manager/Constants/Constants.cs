using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerManager.Constants
{

    class ServiceStringPath
    {
        private static string ServerPath = "https://us-central1-power-manager-0.cloudfunctions.net/";
        public static string getLastVersion = ServerPath + "getLastVersion";
        public static string getServer = ServerPath + "getServer";
        public static string sendFeedback = ServerPath + "sendFeedback";
    }
    
}
