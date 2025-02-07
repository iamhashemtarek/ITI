using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
