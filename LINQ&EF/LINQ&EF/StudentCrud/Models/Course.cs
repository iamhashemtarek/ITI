﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace StudentCrud.Models;

public partial class Course
{
    public int Crs_Id { get; set; }

    public string Crs_Name { get; set; }

    public int? Crs_Duration { get; set; }

    public int? Top_Id { get; set; }

    public virtual ICollection<Ins_Course> Ins_Courses { get; set; } = new List<Ins_Course>();

    public virtual ICollection<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();

    public virtual Topic Top { get; set; }
}