using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    internal class Question
    {
        public int Id {  get; set; } 
        public string Header { get; set; }
        public string[] Answers{ get; set; }
        public Question(int id, string header, string[] answers)
        {
            this.Id = id;
            this.Header = header;
            this.Answers = answers;
        }

        public override string ToString()
        {
            StringBuilder questionAndAnswer = new StringBuilder();
            foreach (string answer in Answers) 
            {
                questionAndAnswer.AppendLine(answer);
            }
            return questionAndAnswer.ToString();
        }
    }
}
