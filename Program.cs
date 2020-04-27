using System;
using System.Threading;

namespace _07_AutoManual
{
    class Program
    {
        static ManualResetEvent manual01;
        static AutoResetEvent auto01;

        static void Main(string[] args)
        {
            manual01 = new ManualResetEvent(false);
            auto01 = new AutoResetEvent(false);
            Thread thread01 = new Thread(Executa01);
            thread01.Start();

            Thread thread02 = new Thread(Executa02);
            thread02.Start();


            //Faz com que a thread espere por 5s e logo depois manda executar
            Thread.Sleep(5000);
            manual01.Set();
            manual01.Reset();

            auto01.Set();

            Thread.Sleep(5000);
            manual01.Set();

            auto01.Set();
            Console.ReadKey();

        }


        static void Executa01()
        {
            Console.WriteLine("01 - Inicia Executa01");
            //Faz com a thread Executa01 pare nesta linha
            manual01.WaitOne();
            Console.WriteLine("02 - Em Execução 01 Executa01");
            Console.WriteLine("03 - Em Execução 02 Executa01");
            manual01.WaitOne();
            Console.WriteLine("04 - Finalizado Executa01");
        }

        static void Executa02()
        {
            Console.WriteLine("01 - Inicia Executa02");
            auto01.WaitOne();
            Console.WriteLine("02 - Em Execução 01 Executa02");
            Console.WriteLine("03 - Em Execução 02 Executa02");
            auto01.WaitOne();
            Console.WriteLine("04 - Finalizado Executa02");
        }


    }
}
