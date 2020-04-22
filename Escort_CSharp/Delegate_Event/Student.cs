using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    class Student
    {
        string id;
        int score;

        public Student(string id, int score)
        {
            this.id = id;
            this.score = score;
        }

        public int Score
        {
            get { return score; }
        }
        
        public string Id
        {
            get { return id; }
        }
    }
}
