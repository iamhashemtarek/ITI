﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DepartmentCRUD.Models;

public partial class Stud_Course
{
    public int Crs_Id { get; set; }

    public int St_Id { get; set; }

    public int? Grade { get; set; }

    public virtual Course Crs { get; set; }

    public virtual Student St { get; set; }
}