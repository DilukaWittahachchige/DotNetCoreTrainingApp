using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Async
{
    public static class AsyncSample
    {

        #region Await Async
        public static async Task callMethod()
        {
            /*
             * In the code given above, Method3 requires one parameter, which is the return type of Method1. 
             * Here, await keyword is playing a vital role for waiting of Method1 task completion. */

            Method2();
            var count = await Method1();
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        #endregion

        #region Async 
        public static void CallMethodTwo()
        {
            Method3();
            Method4();
            Console.ReadKey();
        }

        public static async Task Method3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 40; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void Method4()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }

        #endregion
    }
}
