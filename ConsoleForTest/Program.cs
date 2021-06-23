using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Timers;
using System.Threading;
using ConsoleForTest;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleForTest
{
    ////Написать программу сортировки 
    ////координат точек в массиве структур, 
    ////содержащих объединения по 
    ////убыванию их евклидового расстояния 
    ////относительно точки (0, 0)

    //// + //1 создание двумерного массива;
    //// + // 1.1 Заполененый массив (Array)
    //// 1.2 Массив заполняемый случайными числами (Array + random)
    //// 1.3 Список (List)
    //// 1.4 Список заполняемый случайными числами (List + random)
    ////2 расчет евклидового расстояния; 
    ////3 сортировка по убыванию 
    //class Program
    //{
    //    /// <summary> 
    //    /// Run program function
    //    /// </summary> 
    //    /// <param name="args"></param> 
    //    static void Main(string[] args)
    //    {
    //        int[,] array = null;
    //        double[] arrayDistence = null;
    //        double[] arraySorted = null;

    //        CountValue countValue = new CountValue();

    //        array = countValue.CreateArr();
    //        arrayDistence = countValue.DistanceCalculation(array);
    //        arraySorted = countValue.SortingFunction(arrayDistence);

    //        foreach (int i in arraySorted)
    //        {
    //            Console.WriteLine(i);
    //        }

    //        Console.ReadKey();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            try
            {
                program.GetBatch("ef8790d7-0aba-464f-a0b0-c71918e52062");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        public void GetBatch(string transactionGUID)
        {
            var cnn = ConnectTOoDb();
            var result = GetBatchФttributes(transactionGUID, cnn);
            Console.WriteLine(string.Join(", ", result));
            DisconnectTOoDb(cnn);
        }

        private SqlConnection ConnectTOoDb()
        {
            string connectionString;
            connectionString = @"Data Source=WIN-64Q57B12I4C\FCBD;Initial Catalog=ABBYY;User ID=sa;Password=q1w2e3r4";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Соединение установлено");
            return connection;
        }

        private void DisconnectTOoDb(SqlConnection connection)
        {
            connection.Close();
            Console.WriteLine("Соединение завершено");
        }

        private List<string> GetBatchФttributes(string guid, SqlConnection connection)
        {
            var command = new SqlCommand($@"SELECT TOP (1) [BatchParameter].[BatchId]
                                                ,[BatchParameter].[Value]
                                                ,[Batch].[Name] as [batchName]
                                                ,[Batch].[ProjectId]
                                                ,[Batch].[ProcessingStageId]
                                                ,[Task].[id] as [taskId]
                                            FROM[ABBYY].[dbo].[BatchParameter]
                                            JOIN[ABBYY].[dbo].[Batch] ON[BatchParameter].[BatchId] = [Batch].[Id]
                                            JOIN[ABBYY].[dbo].[Task] ON[Task].[BatchId] = [BatchParameter].[BatchId]
                                            WHERE [BatchParameter].[Value] = '{guid}'", connection);
            
            SqlDataAdapter da = new SqlDataAdapter(command);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            List<string> resultList = new List<string> { };
            foreach (DataRow dr in dt.Rows)
            {
                resultList.Add(dr["BatchId"].ToString());
                resultList.Add(dr["Value"].ToString());
                resultList.Add(dr["batchName"].ToString());
                resultList.Add(dr["ProjectId"].ToString());
                resultList.Add(dr["ProcessingStageId"].ToString());
                resultList.Add(dr["TaskId"].ToString());
            }
            return resultList;
        }
    }

    //class Counter
    //{
    //    public Encoding GetFileEncoding(string srcFile)
    //    {
    //        return null;
    //    }
    //}
}