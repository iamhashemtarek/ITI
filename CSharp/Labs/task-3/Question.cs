using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Question
    {
        string header;
        string body;
        int mark;

        public string Header { get { return header; }  set { header = value; } }
        public string Body { get { return body; } set { body = value; } }
        public int Mark 
        {
            get { return mark; }
            set
            {
                if (mark <= 0)
                    throw new ArgumentOutOfRangeException();
                else
                    mark = value;
            }
        }

        public Question(string header, int mark, string body)
        {
            this.header = header;
            this.mark = mark;
            this.body = body;
        }
        public virtual string getQuestionDetails()
        {
            return $"{header}\n\t{body} ({mark})"; 
        }

    }

}
