using System;

namespace AddMemberEventTest
{
    delegate void AddMemberEventHandler(object sender, AddMemberEvent e);
    class AddMemberEvent : EventArgs
    {
        internal Member Member
        {
            get;
        }
        internal string Name
        {
            get
            {
                return Member.Name;
            }
        }
        internal string Address
        {
            get
            {
                return Member.Address;
            }
        }

        internal AddMemberEvent(Member member)
        {
            this.Member = member;
        }
    }

}
