using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }

        public int Score { get; set; }
    }
}
