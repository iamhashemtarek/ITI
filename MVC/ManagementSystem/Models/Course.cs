﻿using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Course name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Course name must be between 3 and 100 characters.")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Degree must be between 0 and 100.")]

        public int Degree { get; set; }
        [Range(0, 100, ErrorMessage = "Minimum degree must be between 0 and 100.")]
        public int MinDegree { get; set; }
        [Range(1, 10, ErrorMessage = "Course hours must be between 1 and 10.")]

        public int Hours {  get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        [Required(ErrorMessage = "Department ID is required.")]
        public int DeptId {  get; set; }    
        public virtual Department Department { get; set; }
    }
}
