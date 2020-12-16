using System;
using System.Diagnostics;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int size = 7000;
            int[,] b = new int[size, size];
            int res = 0;

            for (int j = 0; j < size; j++)
            {

                for (int k = 0; k < size; k++)
                {
                    b[j, k]++;
                }

            }

            stopwatch.Stop();
            TimeSpan t = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                t.Hours, t.Minutes, t.Seconds,
                t.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadKey();
        }
    }
}