using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//string puthFirst = @"C:\Projects\Spotweld_New\SpotWeld.Net\bin\Debug\Database\SpotWeld2.mdb";
			string puthSecond = @"C:\Users\LEX\Desktop\#3374\SWBK_SN(171018_1321).mdb";

			using (StreamReader sr = new StreamReader(puthSecond, true))
			{
				while (sr.Peek() >= 0)
				{
					Console.WriteLine(sr.ReadToEnd());
				}

				//Чтение только первого символа, чтобы не ждать весь файл
				//sr.Read();

				Console.WriteLine("The encoding used was {0}", sr.CurrentEncoding);
				Console.ReadKey();
			}
		}
	}
}
