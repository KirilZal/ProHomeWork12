using System;
using System.Text;
using System.Threading;

namespace Task1

{
     class Program
    {
        static AutoResetEvent auto = new AutoResetEvent(false);

        static void Fun1()
        {
            Console.WriteLine("push1");
            auto.WaitOne();
            Console.WriteLine("finish1");
        }
        static void Fun2()
        {
            Console.WriteLine("push2");
            auto.WaitOne();
            Console.WriteLine("finish2");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
           Thread thread1= new Thread(Fun1);
            Thread thread2= new Thread(Fun2);
            thread1.Start();
            thread2.Start();

            Thread.Sleep(1000);
            Console.WriteLine("pushing loading");
           
            auto.Set();
            auto.Set();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("finitoooo");
            
        }
    }

}
