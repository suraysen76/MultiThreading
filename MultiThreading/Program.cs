using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            // create a new thread
            Thread t1 = new Thread(Worker1);
            Thread t2 = new Thread(Worker2);

            // start the thread
            t1.Start();
            t2.Start();

            // do some other work in the main thread
            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine("Main thread doing some work #: " +i);
                Thread.Sleep(300);
            }

            // wait for the worker thread to complete
            t1.Join();
            //t2.Join();

            Console.WriteLine("Done");
        }

        static void Worker1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Worker1 thread doing some work #: " + i);
                Thread.Sleep(500);
            }
        }
        static void Worker2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Worker2 thread doing some work #: " + i);
                Thread.Sleep(700);
            }
        }
    }
}
