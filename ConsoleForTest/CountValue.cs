using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTest
{
    public class CountValue
    {
        /// <summary> 
        /// Create array function 
        /// </summary> 
        public int[,] CreateArr()
        {
            int[,] MyArray = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 }, { 9, 10 } };

            //Random ran = new Random();

            //// Инициализируем данный массив 
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        //MyArray[i, j] = ran.Next(0, 10); 
            //        Console.Write("{0}\t", MyArray[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            return MyArray;
        }


        /// <summary> 
        /// Distance calculation function,
        /// Formula for calculating: 
        /// </summary> D(ab) = Math.Sqrt(Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2))
        public void DistanceCalculation(int[,] newArray)
        {
            int[,] distanceArray = null;
            double x0 = 0;
            double y0 = 0;
            double x1 = 0;
            double y1 = 0;

            double countDistance = 0;


            // Инициализируем данный массив 
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    //MyArray[i, j] = ran.Next(0, 10); 
                    Console.Write("{0}\t", newArray[i, j]);

                    //distanceArray[i, j] = newArray[i, j];
                    //if (j < 1)
                    //{
                    //    x1 = newArray.GetLength(0);
                    //}
                    //else y1 = newArray.GetLength(1);

                    //Console.WriteLine($"{x1}, {y1}");
                }
                Console.WriteLine();
            }
        }

        /// <summary> 
        /// Sorting function 
        /// </summary> 
        void SortingFunction()
        { }
    }
}
