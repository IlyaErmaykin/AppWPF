using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTest
{
    /// <summary>
    /// Timer class
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// Timer field
        /// </summary>
        private System.Timers.Timer timer;

        /// <summary>
        /// Result flag field
        /// </summary>
        private bool resultFlag;

        /// <summary>
        /// Set timer function
        /// </summary>
        public void SetTimer(double time, bool flag)
        {
            // Create timer
            this.timer = new System.Timers.Timer(time);
            this.resultFlag = flag;

            this.timer.Elapsed += OnTimerEvent;
            this.timer.AutoReset = true;
            this.timer.Enabled = true;
        }

        /// <summary>
        /// On timer event
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimerEvent(Object source, EventArgs e)
        {
            //if (!resultFlag)
                new Exception();
        }

        /// <summary>
        /// Stop function
        /// </summary>
        public void Stop()
        {
            this.timer.Stop();
        }

        /// <summary>
        /// Dispose function
        /// </summary>
        public void Dispose()
        {
            this.timer.Dispose();
        }
    }
}
