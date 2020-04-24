using System;
using System.Threading;

namespace _01_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciar a thread
            Thread thread = new Thread(ThreadRepeticao);

            //Inicar a thread
            thread.Start();

            //Comprovar que há o processamento em paralelo
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            Console.ReadKey();
        }

        //Ao se utilizar IO - Tela, Rede, Armazenamento 
        //Existe uma demora no processo
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Número: " + i);
            }
        }
    }
}
