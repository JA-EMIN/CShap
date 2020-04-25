using System;
using System.Collections.Generic;
using System.Text;

namespace AddMemberEventTest
{
    class MemberAdder
    {
        internal MemberAdder()
        {
            
        }
        internal void AddMember()
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("주소를 입력하세요 : ");
            string addr = Console.ReadLine();
            
            MemberManager.GetInstance().AddMember(name, addr);
        }
    }
}
