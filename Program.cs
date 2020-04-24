using System;
using System.Threading;

namespace _03_ThreadBackground
{
    class Program
    {
        //Trabalhando com Multithreads
        static void Main(string[] args)
        {
            Console.WriteLine("Data inicial: " + DateTime.Now);

            for(int i = 0; i<5; i++)
            {
                Thread threadFor = new Thread(ThreadRepeticao);
                //Quando o método main encerra, as threads se encerram tbm
                threadFor.IsBackground = true;
                threadFor.Start();
            }

            Console.ReadKey();

        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Número: " + i);
            }

            Console.WriteLine("DataTime: " + DateTime.Now);
        }
    }
}
