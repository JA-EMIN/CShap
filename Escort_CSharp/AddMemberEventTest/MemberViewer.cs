using System;
using System.Collections.Generic;
using System.Text;

namespace AddMemberEventTest
{
    class MemberViewer
    {
        internal MemberViewer()
        {
            MemberManager.GetInstance().AddMemberEventHandler += MemberViewer_AddMemberEventHandler;
        }

        private void MemberViewer_AddMemberEventHandler(object sender, AddMemberEvent e)
        {
            Console.WriteLine("멤버가 추가되었습니다.");
            Console.WriteLine("{0}, {1}", e.Name, e.Address);
        }
    }
}
