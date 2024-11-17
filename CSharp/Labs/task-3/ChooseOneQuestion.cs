using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class ChooseOneQuestion : Question
    {
        public string[] Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public ChooseOneQuestion(int mark, string body, string[] answers, string correctAnswer)
            : base("choose one answer", mark, body)
        {
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public override string getQuestionDetails()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{base.Header}");
            result.AppendLine($"\t{base.Body} ({base.Mark})");
            result.AppendLine("choices: ");
            for(int i = 0; i < Answers.Length; i++)
            {
                result.AppendLine($"- {Answers[i]}");
            }
            result.AppendLine($"correct answer: {CorrectAnswer}");
            return result.ToString();
        }
    }
}
