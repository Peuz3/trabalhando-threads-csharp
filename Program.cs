using System;
using System.Threading;

namespace _05_ThreadId
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.Start(i);
            }

            Console.ReadLine();
        }

        //Identificar uma thread
        static void ThreadRepeticao(object Id)
        {

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: " + Id + " - Número: " + i + " Id Interno da Thread: " + Thread.CurrentThread.ManagedThreadId);
            }

        }
    }
}
