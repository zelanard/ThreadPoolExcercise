using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadPoolExcercise.Excersizes.ThreadPoolMushrooms
{
    public class Mushroom
    {
        public async void Spore(int seed)
        {
            for (int i = 0; i < seed; i++)
            {
                ThreadPool.QueueUserWorkItem(Growth);
            }
            Console.ReadKey();
        }

        public void Growth(object obj)
        {
            Stopwatch sw = Stopwatch.StartNew();
            string spore = $"Spore: {Thread.CurrentThread.ManagedThreadId}";
            while (sw.ElapsedMilliseconds < 30000)
            {
                Console.WriteLine($"{spore} | Growth progress: {sw}");
            }
            Console.WriteLine($"{spore} is matured. New mushrooms are now growing from the Mycelium!");
        }
    }
}
