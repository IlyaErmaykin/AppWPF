using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleForTest
{
    /// <summary>
    /// Flow class
    /// </summary>
    public class Flows
    {
        /// <summary>
        /// Create flows function
        /// </summary>
        /// <param name="flowCustomLib"></param>
        /// <param name="inputTime"></param>
        /// <param name="resultFlag"></param>
        public static void createFlows(ParameterizedThreadStart parameterizedThreadStart, double inputTime, bool resultFlag)
        {
            var options = new object[2];
            options[0] = inputTime;
            options[1] = resultFlag;

            Thread parralelThread = new Thread(parameterizedThreadStart);
            parralelThread.IsBackground = true;
            parralelThread.Start(options);
        }
    }
}
