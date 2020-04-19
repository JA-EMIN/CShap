using System;
using System.Collections;
using System.Collections.Generic;

namespace IDictionary_인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable ht = new Hashtable();
            Dictionary<string, string> ht = new Dictionary<string, string>();
            ht.Add("홍길동", "율도국");
            ht.Add("장연휴", "이에이치");
            ht["강감찬"] = "대한민국";
            foreach(KeyValuePair<string, string> d in ht)
            {
                Console.WriteLine("Key : {0}, Value : {1}", d.Key, d.Value);
            }


            Console.WriteLine("키목록");
            foreach(string key in ht.Keys)
            {
                Console.WriteLine("Key : {0}", key);
            }

            Console.WriteLine("값목록");
            foreach (string v in ht.Values)
            {
                Console.WriteLine("Value : {0}", v);
            }
            //string value = ht["장연휴"] as string;
            //Console.WriteLine(value);

            //ht.Remove("장연휴");
            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine("Key : {0}, Value : {1}", d.Key, d.Value);
            //}

            //ht.Clear();
            //Console.WriteLine("보관한 요소 개수 : {0}", ht.Count);
            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine("Key : {0}, Value : {1}", d.Key, d.Value);
            //}

        }
    }
}
