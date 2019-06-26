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
        static void Main(string[] args)
        {
            Program program = new Program();

            program.happyFunction();

            //Timer myTimer = new Timer(new TimerCallback(CallBack), null, 0, 500);

            Console.ReadKey();

        }

        private void happyFunction()
        {
            //var input;

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
                                               "     ******************************"    ,
                                               "    ********************************"    ,
                                               "   **********************************"    ,
                                               "  ************************************"    ,
                                               " **************************************"   ,
                                               "****************************************"  };

           
            
            for (int i = 0; i <= 22; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(array[i]);
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(array[i]);
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(array[i]);
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(array[i]);
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(array[i]);
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(array[i]);
                            break;
                        }
                    default :
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(array[i]);
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

