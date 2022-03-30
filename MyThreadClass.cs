using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BasicThreading
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                System.Diagnostics.Debug.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
