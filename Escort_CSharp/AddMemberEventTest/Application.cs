using System;
using System.Collections.Generic;
using System.Text;

namespace AddMemberEventTest
{
    public class Application
    {
        static Application application = null;
        MemberAdder ma = null;
        MemberViewer mv = null;
        public static Application GetInstance()
        {
            if (application == null)
            {
                application = new Application();
            }
                
            return application;
        }

        private Application()
        {
            ma = new MemberAdder();
            mv = new MemberViewer();
        }
        internal void Run()
        {
            bool check = false;
            do
            {
                Console.WriteLine("회원추가:[1]");
                Console.WriteLine("다른 키를 누르면 종료합니다.");
                ConsoleKey key = Console.ReadKey(true).Key;
                check = (key == ConsoleKey.D1);
                if(check)
                {
                    Console.WriteLine();
                    ma.AddMember();
                }
            } while (check);
        }
    }
}
