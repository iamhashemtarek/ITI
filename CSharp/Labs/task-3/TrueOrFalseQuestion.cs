using System;

namespace task_3
{
    internal class TrueOrFalseQuestion : Question
    {
        public bool CorrectAnswer { get; }

        public TrueOrFalseQuestion(int mark, string body, bool correctAnswer)
            : base("true of false", mark, body)
        {
            CorrectAnswer = correctAnswer;
        }

        public override string getQuestionDetails()
        {
            return $"{base.getQuestionDetails()}\n\tcorrect answer: {CorrectAnswer}";
        }
    }
}
