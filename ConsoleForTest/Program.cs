using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConsoleForTest
{
    //Написать программу сортировки 
    //координат точек в массиве структур, 
    //содержащих объединения по 
    //убыванию их евклидового расстояния 
    //относительно точки (0, 0)

    //1 создание двумерного массива;
    // 1.1 Заполененый массив (Array)
    // 1.2 Массив заполняемый случайными числами (Array + random)
    // 1.3 Список (List)
    // 1.4 Список заполняемый случайными числами (List + random)
    //2 расчет евклидового расстояния; 
    //3 сортировка по убыванию 
    class Program
    {
        /// <summary> 
        /// Run program function
        /// </summary> 
        /// <param name="args"></param> 
        static void Main(string[] args)
        {
            int[,] array = null;

            CountValue countValue = new CountValue();

            array = countValue.CreateArr();
            countValue.DistanceCalculation(array);
            //var arr = CreateArr
            //DistanceCalculation(int MyArray[,]);

            Console.ReadKey();
        }
    }

    //class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        //Counter counter = new Counter();

    //        string sourcePath_1 = @"D:\users\IErmaykin\Desktop\Слата\inpetRevice.xls";
    //        string sourcePath_2 = @"D:\users\IErmaykin\Desktop\Слата\output.xlsx";

    //        // only one instance of excel
    //        Excel.Application excelApplication = new Excel.Application();

    //        excelApplication.Workbooks.Add();
    //        string in_path = sourcePath_1;
    //        string out_path = sourcePath_2;
    //        Excel.Workbook in_workbook = excelApplication.Workbooks.Open(in_path);
    //        Excel.Workbook out_workbook = excelApplication.Workbooks.Open(out_path);
    //        Excel.Worksheet in_workSheet = in_workbook.Worksheets.get_Item(1);
    //        Excel.Worksheet out_workSheet = out_workbook.Worksheets.get_Item(1);

    //        //Excel.Range source = (Excel.Range)(in_workSheet.UsedRange.Range["B2"]); 


    //        // TO DO
    //        // Worksheet in_workSheet_1 = Global. //.GetVstoObject(this.Appliacation.ActiveWorkbook.Worksheets[1]);
    //        // Excel.Range source = in_workSheet_1.Range["B2", "M12"].Value2;



    //        Excel.Range dest = out_workSheet.Range["O1"];
    //        //source.Copy(dest);


    //        //var srcPath = sourcePath_1;
    //        //Excel.Workbook srcworkBook = excelApplication.Workbooks.Open(srcPath);
    //        //Excel.Worksheet srcworkSheet = srcworkBook.Worksheets.get_Item(1);

    //        //var destPath = sourcePath_2;
    //        //Excel.Workbook destworkBook = excelApplication.Workbooks.Open(destPath, 0, false);
    //        //Excel.Worksheet destworkSheet = destworkBook.Worksheets.get_Item(1);

    //        //Excel.Range from = srcworkSheet.Range;
    //        //Excel.Range to = destworkSheet.Range("");

    //        //// if you use 2 instances of excel, this will not work
    //        //from.Copy(to);

    //        //destworkBook.SaveAs("C:\\Documents and Settings\\HARRY\\Desktop\\FIXED Aging incident Report " + DateTime.Now.ToString("MM_dd_yyyy") + ".xls");
    //        //srcxlApp.Application.DisplayAlerts = false;
    //        //destxlApp.Application.DisplayAlerts = false;
    //        //destworkBook.Close(true, null, null);
    //        //srcworkBook.Close(false, null, null);
    //        //excelApplication.Quit();

    //        Console.ReadKey();
    //    }
    //}

    class Counter
    {
        public Encoding GetFileEncoding(string srcFile)
        {
            return null;
        }
    }
}
