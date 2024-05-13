using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolExcercise.Excersizes
{
    internal class ThreadPoolTutorail
    {
        static void Main2(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start();
            ProcessWithThreadPoolMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
        }

        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        /// <summary>
        /// Skal metoden Process() tage et object som argument, begrund dit svar?
        /// 
        /// ProcessWithThreadMethod har en overflow med signaturen (WaitCallback callBack).
        /// WaitCallback har signaturen (object obj).
        /// 
        /// For at ProcessWithThreadMethod skal matche den overflow der har WaitCallback, skal metoden der parses til den matche WaitCallback(object obj).
        /// Derfor skal Process have et object som argument.
        /// </summary>
        /// <param name="callback"></param>
        static void Process(object callback)
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                }
            }
        }

    }
}
