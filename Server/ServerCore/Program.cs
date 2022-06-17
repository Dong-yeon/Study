using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {

        static void MainThread(object state)
        {

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Hello Thread!");
        }


        static void Main(string[] args)
        {

            // 쓰레드 풀 구현
            ThreadPool.SetMinThreads(1, 1);
            ThreadPool.SetMinThreads(5, 5);

            // Task 구현

            for (int i = 0; i < 5; i++)
            {
                Task t = new Task(() => { while (true) { } }, TaskCreationOptions.LongRunning);
                t.Start();
            }

            //for (int i=0; i < 4; i++)
            //{
            //    ThreadPool.QueueUserWorkItem((obj) => { while (true) { } });
            //}

            ThreadPool.QueueUserWorkItem(MainThread);

            // 멀티 쓰레드 구현
            //for (int i = 0; i < 1000; i++)
            //{
            //    Thread t = new Thread(MainThread);
            //    //t.Name = "Test Thread";
            //    t.IsBackground = true;
            //    t.Start();
            //}
            //Console.WriteLine("Waiting for Thread");
            //t.Join();

            //Console.WriteLine("Hello world");

            while (true)
            {

            }
        }

    }
}
