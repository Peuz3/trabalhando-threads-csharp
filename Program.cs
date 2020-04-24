using System;
using System.Threading;

namespace _04_ThreadSafe
{
    class Program
    {
        static int Rede = 0;
        static object VariavelDeControle = 0;

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
                //Neste bloco as threads irão utlizar os recursos uma por vez
                //Caso haja muitas threads, este bloco faz com que o programa não fique muito lento
                //FIFO
                lock (VariavelDeControle)
                {
                    Console.WriteLine("Número: " + i);

                    Rede++;
                }
               
            }
            

            

            Console.WriteLine("DataTime: " + DateTime.Now);
        }
    }
}
