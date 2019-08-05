using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Activities;

namespace ConsoleForTest
{
    class FlowCustomLib : CodeActivity
    {
        /// <summary>
        /// Flow custom lib field
        /// </summary>
        FlowCustomLib flowCustomLib = new FlowCustomLib();

        /// <summary>
        /// Time property
        /// </summary>
        public double Time { get; set; }

        /// <summary>
        /// Result flag property
        /// </summary>
        public bool ResultFlag { get; set; }

        /// <summary>
        /// Execute function
        /// </summary>
        /// <param name="context"></param>
        public void Execute()
        {
            double inputTime = Time;
            bool resultFlag = ResultFlag;

            Flows.createFlows(new ParameterizedThreadStart(this.runFunction), inputTime, resultFlag);
        }

        /// <summary>
        /// Run function
        /// </summary>
        /// <param name="obj"></param>
        public void runFunction(object obj)
        {
            var objArray = (object[])obj;
            double inputTime = (double)objArray[0];
            bool resultFlag = (bool)objArray[1];

            Timer timer = new Timer();

            timer.SetTimer(inputTime, resultFlag);
            timer.Stop();
            timer.Dispose();
        }

        protected override void Execute(CodeActivityContext context)
        {
            throw new NotImplementedException();
        }
    }
}
