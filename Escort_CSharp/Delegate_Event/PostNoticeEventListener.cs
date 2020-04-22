using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate void PostDele(string msg);
    class PostNoticeEventListener
    {
        public event PostDele PostEventMessage;
        public string Message
        {
            get;
            set;
        }
        public PostNoticeEventListener(string message)
        {
            this.Message = message;
        }

        public void SendToSMS(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("SendToSMS Success");
        }

        public void SendToKAKA(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("SendToKAKA Success");
        }
        public void SendToARS(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("SendToARS Success");
        }

        public void SendMessage(string msg)
        {
            if (msg != null)
                PostEventMessage(msg);
            else
                PostEventMessage(this.Message);
        }
    }
}
