using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace _04LabEx1
{
    internal class MyThreadClass
    {

        public  static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            
            for (int i = 0; i < 6; i++) {
                Thread.Sleep(1500);
                Console.WriteLine("Name of thread: " + thread.Name + " = " + i);
            }
            
            
        }


    }
}
