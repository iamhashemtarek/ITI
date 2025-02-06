using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{
    public class Teacher : User
    {
        public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
    }
}
