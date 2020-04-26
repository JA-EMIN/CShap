using System;
using System.Collections;

namespace IComparable_IComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 배열 ArrayList
            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(21);
            //}

            //foreach (int i in arr)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();
            //Array.Sort(arr);
            //Console.WriteLine("===== 정렬 후 =====");
            //foreach (int i in arr)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.Clear();

            //ArrayList ar = new ArrayList();
            //for (int i = 0; i < 10; i++)
            //{
            //    ar.Add(random.Next(21));
            //}

            //foreach (int i in ar)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();
            //ar.Sort();
            //Console.WriteLine("===== 정렬 후 =====");
            //foreach (int i in ar)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.Clear();
            #endregion

            Man[] men = new Man[4];
            men[0] = new Man("홍길동", "율도국");
            men[1] = new Man("강감찬", "대한민국");
            men[2] = new Man("김구", "제주도");
            men[3] = new Man("을지문덕", "천안");

            foreach (Man man in men)
            {
                Console.WriteLine(man);
            }

            Array.Sort(men);
            Console.WriteLine("===== 이름순 정렬 후 =====");
            foreach (Man man in men)
            {
                Console.WriteLine(man);
            }

            AddrComparer ac = new AddrComparer();
            Array.Sort(men, ac);
            Console.WriteLine("===== 주소순 정렬 후 =====");
            foreach (Man man in men)
            {
                Console.WriteLine(man);
            }


        }
    }  
}
