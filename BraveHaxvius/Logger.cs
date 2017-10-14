using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveHaxvius
{
    public static class Logger
    {
        public static StringBuilder LogString = new StringBuilder();
        public delegate void LogHookDelegate(String x);
        public static LogHookDelegate LogHook;
        public static void Out(string str)
        {
            Console.WriteLine(str);
            LogString.Append(str).Append(Environment.NewLine);
            LogHook?.Invoke(str);
        }
    }
}
