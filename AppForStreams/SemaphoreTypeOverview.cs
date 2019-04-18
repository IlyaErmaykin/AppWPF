﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AppForStreams
{
    class SrartApp
    {
        public void SrartAppFunction()
        {
            for (int i = 1; i < 6; i++)
            {
                Reader reader = new Reader(i);
            }
        }
    }

    class Reader
    {
        // создаем семафор
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;// счетчик чтения

        public Reader(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = "Читатель " + i.ToString();
            myThread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();

                Console.WriteLine("{0} входит в библиотеку", Thread.CurrentThread.Name);

                Console.WriteLine("{0} читает", Thread.CurrentThread.Name);
                Thread.Sleep(1000);

                Console.WriteLine("{0} покидает библиотеку", Thread.CurrentThread.Name);

                sem.Release();

                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
