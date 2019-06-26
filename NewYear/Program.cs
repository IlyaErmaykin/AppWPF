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
        /// <summary>
        /// String off set cost
        /// </summary>
        const string stringOffset = " ";

        /// <summary>
        /// String count const
        /// </summary>
        const string stringCount = "*";

        /// <summary>
        /// aTimer field
        /// </summary>
        private static System.Timers.Timer aTimer;

        /// <summary>
        /// _random field
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Main function;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program program = new Program();

            program.SetTimer();

            Console.ReadKey();
            aTimer.Stop();
            aTimer.Dispose();
        }

        /// <summary>
        /// Rewrite TreeAction
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void rewriteTreeAction(object source, EventArgs e)
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

        /// <summary>
        /// Get random console color
        /// </summary>
        /// <returns></returns>
        private ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        /// <summary>
        /// Set timer function
        /// </summary>
        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(300);
  
            aTimer.Elapsed += rewriteTreeAction;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
}

