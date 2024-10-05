using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCoMa
{
    public static class Logger
    {
        public static event EventHandler<string> OnMessage = delegate { };
        public static void Log(string message) 
        { 
            OnMessage.Invoke(null, message);
        }
    }
}
