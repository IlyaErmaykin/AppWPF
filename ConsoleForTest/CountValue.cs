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
        public double[] DistanceCalculation(int[,] newArray)
        {
            double[] distanceArray = new double[5];
            double x0 = 0;
            double y0 = 0;


            //double countDistance = 0;

            // Инициализируем данный массив 
            for (int i = 0; i < newArray.GetLength(0); i++)
            {

                double x1 = 0;
                double y1 = 0;

                double result = 0;

                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (x1 == 0)
                    {
                        x1 = newArray[i, j];
                    }
                    else
                    {
                        y1 = newArray[i, j];
                    }
                }

                result = Math.Sqrt((Math.Pow((x0 - x1), 2) + Math.Pow((y0 - y1), 2)));
                //Console.WriteLine(result);
                distanceArray[i] = result;
            }

            return distanceArray;
        }

        /// <summary> 
        /// Sorting function 
        /// </summary> 
        public double[] SortingFunction(double[] newArray)
        {
            Array.Sort(newArray);
            Array.Reverse(newArray);

            return newArray;
        }
    }
}