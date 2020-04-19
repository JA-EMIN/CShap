using System;
using System.Collections;
using System.Collections.Generic;

namespace ICollection_인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack : LIFO(Last In First Out)
            //Stack stack = new Stack();
            //stack.Push(3);
            //stack.Push(2);
            //stack.Push(1);

            //Console.WriteLine(stack.Pop());     //1출력, 스택에는 3 2
            //Console.WriteLine(stack.Pop());     //2출력, 스택에는 3
            //while(stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //Queue : FIFO(First In First Out)
            Queue q = new Queue();
            q.Enqueue(4);
            q.Enqueue(3);
            q.Enqueue(2);
            q.Enqueue(1);

            Console.WriteLine(q.Dequeue()); //4출력, Queue : 3, 2, 1
            while(q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());     //3, 2, 1 출력
            }
                                 
            //interface IList:ICollection
            //{
            //}
            // 배열 : IList(ArrayList 구현) : ICollection(Queue, Stack 구현) : IEnumerable 순으로 상속받아 구현 되어 있음

            //interface ICollection : IEnumerable
            //{
            //}

            //int[] arr = new int[3] { 1, 2, 3 };
            //View(arr);

            //ArrayList ar = new ArrayList();
            //ar.Add(2);
            //ar.Add(3);
            //View(ar);

            //int[] srcArr = new int[3] { 1, 2, 4 };
            //int[] dstArr = new int[5] { 11, 12, 13, 14, 15 };
            //srcArr.CopyTo(dstArr, 2);

            //View(dstArr);
        }

        private static void View(ICollection arr)
        {
            Console.WriteLine("Count : {0}", arr.Count);
            foreach (Object obj in arr)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();
        }
    }
}
