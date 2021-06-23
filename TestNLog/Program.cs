using System;
using NLog;

namespace TestNLog
{
    class Program
    {
        /// <summary>
        /// Nlog field
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program program = new Program();

            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");

            program.SomeFunction();
        }

        /// <summary>
        /// Some function
        /// </summary>
        private void SomeFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Hello World!");
                Exception e;
            }
        }
    }
}
