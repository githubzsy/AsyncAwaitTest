using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitAsyncTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main开始:当前线程:" + Thread.CurrentThread.ManagedThreadId);
            int c = await Task.Run(() =>
            {
                Console.WriteLine("Task.Run内部:当前线程:" + Thread.CurrentThread.ManagedThreadId);
                return 1 + 2;
            });
            GetString(c);
            Console.WriteLine("Main结束:当前线程:" + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }
        

        static string GetString(int c)
        {
            Console.WriteLine("GetString内部:当前线程:" + Thread.CurrentThread.ManagedThreadId);
            return c.ToString();
        }
    }
}
