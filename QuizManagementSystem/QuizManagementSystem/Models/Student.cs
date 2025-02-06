using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{
    public class Student : User
    {
        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
