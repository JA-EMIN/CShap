using System;
using System.Collections.Generic;
using System.Text;

namespace AddMemberEventTest
{
    class Member
    {
        internal string Name
        {
            get;
            private set;
        }

        internal string Address
        {
            get;
            private set;
        }

        internal Member(string name, string Address)
        {
            this.Name = name;
            this.Address = Address;
        }
    }
}
