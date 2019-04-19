using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTest
{
    ////Написать программу сортировки 
    ////координат точек в массиве структур, 
    ////содержащих объединения по 
    ////убыванию их евклидового расстояния 
    ////относительно точки (0, 0)

    ////1 создание двумерного массива;
    //// 1.1 Заполененый массив (Array)
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

    //        CountValue countValue = new CountValue();

    //        array = countValue.CreateArr();
    //        countValue.DistanceCalculation(array);
    //        //var arr = CreateArr
    //        //DistanceCalculation(int MyArray[,]);

    //        Console.ReadKey();
    //    }
    //}

    class Program 
    {

        static void Main(string[] args)
        {
            Counter counter = new Counter();

            string sourcePath_1 = @"C:\Users\LEX\Desktop\_1.txt";
            string sourcePath_2 = @"C:\Users\LEX\Desktop\_2.txt";
            string sourceText = "牛肉";

            string unicodeString = "his string contains the unicode character Pi (\u03a0)";
            //var result = counter.GetFileEncoding(sourceText);

            //byte[] utbBytes = Encoding.UTF8.GetBytes(sourceText);
            //var result = Encoding.UTF8.GetString(utbBytes, 0, utbBytes.Length);

            //var result = Encoding.GetEncoding(sourcePath);
            //var result = Encoding.RegisterProvider

            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            byte[] unicodeBytes = unicode.GetBytes(sourceText);

            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            Console.WriteLine("Original string: {0}", unicodeString);
            Console.WriteLine("Ascii converted string: {0}", asciiString);

            //Console.WriteLine(sourceText);
            //Console.WriteLine(result);

            Console.ReadKey();
        }
    }
     
    class Counter
    {
        public Encoding GetFileEncoding(string srcFile)
        {
            /// Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(srcFile, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }
    }
}
