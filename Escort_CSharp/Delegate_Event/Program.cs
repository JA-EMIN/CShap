using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Student> students = new Dictionary<string, Student>();
            //students.Add("2019-000001", new Student("2019-000001", 80));
            //students.Add("2019-000002", new Student("2019-000002", 75));
            //students.Add("2019-000003", new Student("2019-000003", 90));
            //students.Add("2019-000004", new Student("2019-000004", 91));
            //students.Add("2019-000005", new Student("2019-000005", 69));

            //Score score = new Score(80);
            //score.GetRequireScore(students, new ScoreCompare(score.GetFailScore));

            //Console.WriteLine();

            //score.PASS_SCORE = 70;
            //score.GetRequireScore(students, new ScoreCompare(score.GetPassScore));

            PostNoticeEventListener postNoticeEventListener = new PostNoticeEventListener("Hello");
            postNoticeEventListener.PostEventMessage += postNoticeEventListener.SendToARS;
            postNoticeEventListener.PostEventMessage += postNoticeEventListener.SendToKAKA;
            postNoticeEventListener.PostEventMessage += postNoticeEventListener.SendToSMS;

            postNoticeEventListener.SendMessage(null);
        }
    }
}
