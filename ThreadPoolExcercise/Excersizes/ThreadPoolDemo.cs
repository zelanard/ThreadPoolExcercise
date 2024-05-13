using System;
using System.Threading;

namespace ThreadPoolExcercise
{
    
    /// <summary>
    /// <c>ThreadPoolDemo</c> is a C# Program to Create Thread Pools
    /// </summary>
    class ThreadPoolDemo
    {
        /// <summary>
        /// This is a method to demonstrate a Demo Task.
        /// </summary>
        /// <param name="obj"></param>
        public void task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        /// <summary>
        /// this is a method to demonstrate another demo class.
        /// </summary>
        /// <param name="obj"></param>
        public void task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }

        /// <summary>
            /// this is the main entrypoint to the program
            /// in this method we are queueing each of the tasks into the threadpool twice.
        /// </summary>
        /// <remarks>
            /// to answer the question posed by the excersize, I am going to pass the explanation I sent to the discord gorup here:
            /// Både delegates og callbacks bruges til at parse en method/function som et argument til en anden funktion. Forskellen på dem er, at delegates er type sensitive, mens callbacks ikke nødvendigvis er det.  Delegates har en specifik syntax, hvilket callbacks ikke har.  Når du erklærer en delegate, definerer du dens signatur. Den samler så alt, hvad der matcher dens signatur, op inden for dens scope.
            /// DVS: det er ikke helt forkert at sige at delegates er en type af callbacks...
            ///
            /// Grunden til at de to metoder ser ud til at gøre det samme, er at de faktisk gør det samme.
            /// WaitCallback er en delegate og vi parser tpd.task1 til den som et argument.
            ///
            /// WaitCallback er erklæret noget i den her stil: public delegate void WaitCallback(object state); dens signatur er altså: method(object).
            /// Derfor kan vi parse tpd.task1 til den fordi dens signatur også er method(object).
            ///
            /// Overload: En metode kan have forskellige overloads. Hver overload har en forskellig signatur. QueueUserWorkItem har 3 forskellige overloads, dvs. der findes 3 forskellige metoder med samme navn men forskellige signaturer.
            ///
            /// WaitCallBack Signatur: (object obj)
            /// Vi bruger QueueUserWorkItem med Signaturen: (WaitCallback callBack)
            ///
            /// Vi kan altså enten parse et WaitCallBack til QueueUserWorkItem, eller bare en metode der matcher WaitCallback's signatur. dvs. en metode med signaturen (object obj).
        /// </remarks>
        static void Main1()
        {
            ThreadPoolDemo tpd = new ThreadPoolDemo();
            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
            }
            Console.Read();
        }
    }
}
