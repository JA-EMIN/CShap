using System;
using System.Collections.Generic;
using System.Text;

namespace AddMemberEventTest
{
    class MemberManager
    {
        Dictionary<string, Member> members = new Dictionary<string, Member>();
        static MemberManager mm;
        internal event AddMemberEventHandler AddMemberEventHandler = null;
        internal static MemberManager GetInstance()
        {
            if (mm == null)
                mm = new MemberManager();
            return mm;
        }
        internal void AddMember(string name, string addr)
        {
            if(!members.ContainsKey(name))
            {
                members.Add(name, new Member(name, addr));
                if (AddMemberEventHandler != null)
                    AddMemberEventHandler(this, new AddMemberEvent(members[name]));

            }
        }
    }
}
