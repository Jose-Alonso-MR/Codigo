using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCurso.NET18
{
    public static class Log
    {

        public static void WriteInfo(string message)
        {
            Trace.TraceInformation(message);
        }

        public static void WriteWarning(string message)
        {
            Trace.TraceWarning(message);
        }


        public static void WriteError(string message)
        {
            Trace.TraceError(message);
        }

    }
}
