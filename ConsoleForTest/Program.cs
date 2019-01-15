using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTest
{
    //Написать программу сортировки 
    //координат точек в массиве структур, 
    //содержащих объединения по 
    //убыванию их евклидового расстояния 
    //относительно точки (0, 0) 

    //1 создание двумерного массива; 
    //2 расчет евклидового расстояния; 
    //3 сортировка по убыванию 
    class Program
    {
        /// <summary> 
        /// Create array function 
        /// </summary> 
        static int[,] CreateArr()
        {
            int[,] MyArray = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 }, { 9, 10 } };

            //Random ran = new Random();

            // Инициализируем данный массив 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //MyArray[i, j] = ran.Next(0, 10); 
                    Console.Write("{0}\t", MyArray[i, j]);
                }
                Console.WriteLine();
            }
            return MyArray;
        }


        /// <summary> 
        /// Distance calculation function 
        /// </summary> 
        void DistanceCalculation()
        {

        }

        /// <summary> 
        /// Sorting function 
        /// </summary> 
        void SortingFunction()
        { }

        /// <summary> 
        /// 
        /// </summary> 
        /// <param name="args"></param> 
        static void Main(string[] args)
        {
            CreateArr();
            //var arr = CreateArr
            //DistanceCalculation(int MyArray[,]);

            Console.ReadKey();
        }
    }
}
