using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int LoopCount = 0; LoopCount < 6; LoopCount++)
            {       
                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);

            }
        }    
    }
}
