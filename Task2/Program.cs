using System;
using System.Security.AccessControl;
using System.Threading;

namespace Task2
{
    class Program
    {
        private static readonly string myMutex = "MyUniqueMutex";
        private static Mutex mutex;
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool creatNew = false;
            try
            {

                mutex = new Mutex(false, myMutex, out creatNew);
                if (!creatNew)
                {
                    Console.WriteLine("матекс зайнятий");
                    return;
                }
                Console.WriteLine("виконуется програма");
                Console.ReadLine();
                
               
            }
            finally
            {
                if (creatNew && mutex != null)
                {
                    mutex.Dispose();
                }
             

            }

            
            
        }
    }
}
