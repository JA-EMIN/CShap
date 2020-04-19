using System;
using System.Collections;
using System.Collections.Generic;

namespace IList_인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>();
            //ArrayList ar = new ArrayList();
            ar.Add(3);          //순차적으로 삽입
            ar.Insert(0, 8);    //특정 인덱스에 삽입
            ar.Add(4);
            ar.Add(1);
            ar.Insert(1, 7);
            ar.Insert(0, 7);
                      

            ar.Remove(7);   // 8 7 3 4 1
            ar.RemoveAt(0); // 7 3 4 1

            foreach (object obj in ar)
            {
                Console.WriteLine(obj);
            }

            CheckExist(ar, 4);
            //CheckExist(ar, 2);

            for(int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine("ar[{0}] : {1}", i, ar[i]);
            }
        }

        private static void CheckExist(List<int> ar, int v)
        {
            if (ar.Contains(v))
            {
                Console.WriteLine("Exist {0}", v);
                Console.WriteLine("{0}보관 위치 :{1}", v, ar.IndexOf(v));
            }
            else
                Console.WriteLine("None Exist {0}", v);
        }
    }
}
