using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IComparable_IComparer
{
    class Man : IComparable
    {
        string name;
        string addr;
        public string Addr
        {
            get
            {
                return addr;
            }
        }
        public Man(string name, string addr)
        {
            this.name = name;
            this.addr = addr;
        }

        public int CompareTo(object obj)
        {
            Man man = obj as Man;
            if(man.name == null)
            {
                throw new ApplicationException("Man 형식 개체여야 합니다.");
            }
            else
            {
                return this.name.CompareTo(man.name);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", name, addr);
        }
    }

    class AddrComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Man mx = x as Man;
            Man my = y as Man;

            if(mx == null || my == null)
            {
                throw new ApplicationException("Man형식 개체가 아닌 입력 인자가 있습니다.");
            }
            else
            {
                return mx.Addr.CompareTo(my.Addr);
            }
        }
    }
}
