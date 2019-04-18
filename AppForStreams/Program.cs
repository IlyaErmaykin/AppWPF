using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AppForStreams
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** AsyncCallbackDelegate Example *****");
            //Console.WriteLine("Main() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);

            //BinaryOp b = new BinaryOp(Add);
            //IAsyncResult iftAR = b.BeginInvoke(10, 10, new AsyncCallback(AddComplete), null);

            //// Предположим, что здесь выполняется какая-то другая работа..
            //while (!iftAR.IsCompleted)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Working....");
            //}

            SrartApp srartApp = new SrartApp();

            srartApp.SrartAppFunction();

            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            Console.WriteLine("Add () invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("");
        }
    }

}
