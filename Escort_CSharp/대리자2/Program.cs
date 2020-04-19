using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 대리자2
{
    class Program
    {
        public delegate int SquareResult(int i);
        static void Main(string[] args)
        {
            SquareResult s = Square;

            IAsyncResult ar = s.BeginInvoke(10, ResultCallBack, "Hello");
         
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Main : {0}", i);
            }

            Console.ReadKey();
        }



        static int Square(int i)
        {
            Console.WriteLine("제곱 : {0}", i * i);
            return i * i;
        }

        static void ResultCallBack(IAsyncResult ar)
        {

            AsyncResult ar_temp = ar as AsyncResult;
            SquareResult sr_temp = ar_temp.AsyncDelegate as SquareResult;
            int result = sr_temp.EndInvoke(ar);

            Console.WriteLine("작업완료 : {0}, {1}", result, (string)ar.AsyncState);
        }
    }
}
