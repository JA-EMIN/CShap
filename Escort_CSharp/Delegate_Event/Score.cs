using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate bool ScoreCompare(int score);
    class Score
    {
        //일정 점수 이상이냐 이하이냐를 판단해서 점수 이상인 사람의 LIST를 뽑아내는 class
        private int PassScore;
        public Score()
        {
            Console.WriteLine("=== Score CONSTRUCTOR ===");
        }

        public int PASS_SCORE
        {
            get { return PassScore; }
            set { PassScore = value; }
        }
        public Score(int PassScore)
        {
            this.PassScore = PassScore;
        }

        public bool GetPassScore(int score)
        {
            return score >= PassScore;                
        }
        
        public bool GetFailScore(int score)
        {
            return score < PassScore;
        }

        public void GetRequireScore(Dictionary<string, Student> dict, ScoreCompare sc)
        {
            foreach(Student st in dict.Values)
            {
                bool result = sc(st.Score);

                if(result)
                {
                    Console.WriteLine("ID : {0}, Score : {1}", st.Id, st.Score);
                }
            }
        }
    }
}
