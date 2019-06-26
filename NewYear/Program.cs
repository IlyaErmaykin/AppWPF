using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewYear
{
    class Program
    {
        private static System.Timers.Timer aTimer;

        static void Main(string[] args)
        {
            Program program = new Program();

            program.SetTimer();

            //program.happyFunction();

            //Timer myTimer = new Timer(new TimerCallback(CallBack), null, 0, 500);

            Console.ReadKey();

            aTimer.Stop();
            aTimer.Dispose();
        }

        private void happyFunction(object source, EventArgs e)
        {
            //string[] array = new string[] {    "                   /\\"    ,
            //                                   "                   **"    ,
            //                                   "                  ****"    ,
            //                                   "                 ******"    ,
            //                                   "                ********"    ,
            //                                   "               **********"    ,
            //                                   "              ************"    ,
            //                                   "             **************"    ,
            //                                   "            ****************"    ,
            //                                   "           ******************"    ,
            //                                   "          ********************"    ,
            //                                   "         **********************"    ,
            //                                   "        ************************"    ,
            //                                   "       **************************"    ,
            //                                   "      ****************************"    ,
            //                                   "     ******************************"    ,
            //                                   "    ********************************"    ,
            //                                   "   **********************************"    ,
            //                                   "  ************************************"    ,
            //                                   " **************************************"   ,
            //                                   "****************************************"  };

            Console.Clear();
            string[] array = new string[20];
            string stringOffset = " " ;
            string stringCount = "*";

            var resultString = "";

            for (int i = 0; i <= 19; i++)
            {
                var offset = 40 - i;
                var count = (i + 1) * 2;

                for (int y = offset; y > 0; y--)
                {
                    Console.Write(stringOffset);
                }

                for (int z = count; z > 0; z--)
                {
                    Console.ForegroundColor = GetRandomConsoleColor();
                    Console.Write(stringCount);
                }

                Console.WriteLine();
            }
        }

        private Random _random = new Random();
        private ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(300);
  
            aTimer.Elapsed += happyFunction;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
}

