using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class chooseAllQuestion
        : Question
    {
        public string[] Answers { get; set; }
        public string[] CorrectAnswers { get; set; }

        public chooseAllQuestion(int mark, string body, string[] answers, string[] correctAnswers)
            : base("choose all correct answers", mark, body)
        {
            Answers = answers;
            CorrectAnswers = correctAnswers;
        }

        public override string getQuestionDetails()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{base.Header}");
            result.AppendLine($"\t{base.Body} ({base.Mark})");
            result.AppendLine("choices: ");
            for (int i = 0; i < Answers.Length; i++)
            {
                result.AppendLine($"- {Answers[i]}");
            }
            result.AppendLine("correct answers: ");
            for (int i = 0; i < CorrectAnswers.Length; i++)
            {
                result.AppendLine($"- {CorrectAnswers[i]}");
            }
            return result.ToString();
        }
    }
}
