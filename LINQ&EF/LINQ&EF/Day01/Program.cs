using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //Query1: Display numbers without any repeated Data and sorted
            //var q1 = numbers.OrderBy(num => num).Distinct().ToList();
            //Console.WriteLine("sorted and distinct: ");
            //foreach (int num in q1)
            //{
            //    Console.WriteLine(num);
            //}

            ////Query2: using Query1 result and show each number and it’s multiplication
            //var q2 = q1.Select(num => new { number = num, multiply = num * num }).ToList();
            //foreach (var num in q2)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region part02
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            ////Query1: Select names with length equal 3.

            ////query expression
            //var q1 = from name in names
            //         where name.Length == 3
            //         select name;

            //Console.WriteLine("Q1 -> query expression:");
            //foreach (var name in q1)
            //{
            //    Console.WriteLine(name);
            //}

            ////method expression
            //var q2 = names.Where(name => name.Length == 3);
            //Console.WriteLine("Q1 -> method expression:");
            //foreach (var name in q2)
            //{
            //    Console.WriteLine(name);
            //}

            ////Query2: Select names that contains “a” letter (Capital or Small )then sort them by length
            //var q3 = names.Where(name => name.ToLower().Contains("a")).OrderBy(name => name.Length);
            //Console.WriteLine("Q2 -> method expression: ");
            //foreach (var name in q3)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("Q2 -> query expression: ");
            //var q4 = from name in names
            //         where name.ToLower().Contains("a")
            //         orderby name.Length
            //         select name;
            //foreach (var name in q4)
            //{
            //    Console.WriteLine(name);
            //}

            ////Query3: Display the first 2 names
            //var q5 = names.Take(2);
            //Console.WriteLine("Q3 -> method expression");
            //foreach (var name in q5)
            //{
            //    Console.WriteLine(name);
            //}

            //var q6 = (from name in names
            //          select name).Take(2);
            //Console.WriteLine("Q3 -> query expression");
            //foreach (var name in q6)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region part03
            //List<Student> students = new List<Student>()
            //{
            //    new Student()
            //    {
            //        ID=1, FirstName="Ali", LastName="Mohammed",
            //        subjects=new Subject[]
            //        {
            //            new Subject() {Code = 22, Name = "EF"},
            //            new Subject() {Code = 33, Name = "UML"}
            //        }
            //    },
            //    new Student()
            //    {
            //        ID=1, FirstName="Mona", LastName="Gala",
            //        subjects=new Subject[]
            //        {
            //            new Subject() {Code = 22, Name = "EF"},
            //            new Subject() {Code = 34, Name = "XML"},
            //            new Subject() {Code = 25, Name = "JS"}
            //        }
            //    },
            //    new Student()
            //    {
            //        ID=1, FirstName="Yara", LastName="Yousf",
            //        subjects=new Subject[]
            //        {
            //            new Subject() {Code = 22, Name = "EF"},
            //            new Subject() {Code = 25, Name = "JS"}
            //        }
            //    },
            //    new Student()
            //    {
            //        ID=1, FirstName="Ali", LastName="Ali",
            //        subjects=new Subject[]
            //        {
            //            new Subject() {Code = 33, Name = "UML"}
            //        }
            //    },

            //};

            ////Query1: Display Full name and number of subjects for each student as follow
            //var q1 = students.Select(student => new
            //{
            //    FullName = student.FirstName + " " + student.LastName,
            //    NoOfSubjects = student.subjects.Count()
            //});
            //Console.WriteLine("Q1:");
            //foreach (var student in q1) Console.WriteLine(student);

            ////Query2: Write a query which orders the elements in the list by FirstName
            ////Descending then by LastName Ascending and result of query displays only first
            ////names and last names for the elements in list as follow
            //var q2 = students.OrderByDescending(student => student.FirstName)
            //    .ThenBy(student => student.LastName)
            //    .Select(student => $"{student.FirstName} {student.LastName}");
            //Console.WriteLine("Q2:");
            //foreach (var student in q2) Console.WriteLine(student);

            ////Query3: Display each student and student’s subject as follow (use selectMany)
            //var q3 = students.SelectMany(
            //    student => student.subjects,
            //    (student, subject) => new
            //    {
            //        studentName = student.FirstName + " " + student.LastName,
            //        subjectName = subject.Name
            //    }
            //);
            //Console.WriteLine("Q3");
            //foreach (var student in q3) Console.WriteLine(student);

            ////Bonus
            //var q4 = students.GroupBy(
            //    student => student.FirstName,
            //    student => student.subjects
            //);
            //Console.WriteLine("Bonus");
            //foreach (var st in q4)
            //{
            //    Console.WriteLine($"{st.Key}: ");
            //    foreach (var subject in st.SelectMany(sub => sub))
            //    {
            //        Console.WriteLine($"{subject.Name}");
            //    }
            //}   
            #endregion
        }
    }
}
