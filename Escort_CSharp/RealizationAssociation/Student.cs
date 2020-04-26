using System;
using System.Collections.Generic;
using System.Text;

namespace RealizationAssociation
{
    class Student : Man, IStudy 
    {
        readonly int sn;
        internal Student(string name, int sn) : base(name)
        {            
            this.name = name;
            this.sn = sn;
        }
        public override void Intro()
        {
            Console.WriteLine("번호:{0}", sn);
            base.Intro();
        }
        public void Study()
        {
            Intro();
            Console.WriteLine("학습합니다.");
        }
    }
}
