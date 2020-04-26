using System;
using System.Collections.Generic;
using System.Text;

namespace RealizationAssociation
{
    class Man
    {
        protected string name;
        internal Man(string name)
        {
            this.name = name;
        }

        public virtual void Intro()
        {
            Console.WriteLine("{0} 입니다.", name);
        }

    }
}
