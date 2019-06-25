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
        static string[] colors = Enum.GetNames(typeof(ConsoleColor));
        static int index = 0;

        static void Main(string[] args)
        {
            Program program = new Program();

            program.happyFunction();

            //Timer myTimer = new Timer(new TimerCallback(CallBack), null, 0, 500);

            Console.ReadKey();

        }

        enum Colors
        {
            White = 1,
            Blue = 2,
            Red = 3,
            Green = 4,
            Yellow = 5,
            Pinc = 6,
            BlueViolet = 7
        }

        private void happyFunction()
        {
            var input = Console.ReadKey();

            string[] array = new string[] {    "                   /\\"    ,
                                               "                   **"    ,
                                               "                  ****"    ,
                                               "                 ******"    ,
                                               "                ********"    ,
                                               "               **********"    ,
                                               "              ************"    ,
                                               "             **************"    ,
                                               "            ****************"    ,
                                               "           ******************"    ,
                                               "          ********************"    ,
                                               "         **********************"    ,
                                               "        ************************"    ,
                                               "       **************************"    ,
                                               "      ****************************"    ,
                                               "     ******************************"   ,
                                               "    ********************************"    ,
                                               "   **********************************"    ,
                                               "  ************************************"    ,
                                               " **************************************"   ,
                                               "****************************************"  };

           
            
            while (input.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                foreach (string i in array)
                {
                    switch (i)
                    {
                        case "1":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(i);
                                break;
                            }
                        case "2":
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(i);
                                break;
                            }
                        case "3":
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(i);
                                break;
                            }
                        case "4":
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(i);
                                break;
                            }
                        case "5":
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(i);
                                break;
                            }
                        case "6":
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(i);
                                break;
                            }
                        default :
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(i);
                                break;
                            }
                    }
                }
                    
                //foreach (string i in array)
                //{
                //    Console.Clear();
                //    //if (i )
                //    Console.WriteLine(i);
                //}
            }                
            
        }     
    }
}
