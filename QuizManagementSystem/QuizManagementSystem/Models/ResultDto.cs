using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{
    public class ResultDto
    {
        public string QuizTitle { get; set; }
        public string StudentName { get; set; }
        public int Score { get; set; }
    }
}
