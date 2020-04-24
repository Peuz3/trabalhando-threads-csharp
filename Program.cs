using System;
using System.Threading;

namespace _02_Thread
{
    class Program
    {
        //Trabalhando com Multithreads
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For: " + i);
                Thread thread = new Thread(ThreadRepeticao);
                thread.Start();
            }

            Console.WriteLine("Fim do Fluxo!");

        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Número: " + i);
            }
        }
    }
}
