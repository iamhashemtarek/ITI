using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace myspace
{
    internal class Program
    {
        class MyEqualityComparer : IEqualityComparer<Empolyee>
        {
            public bool Equals(Empolyee? x, Empolyee? y)
            {
                if(x == null || y == null) return false;
                if(x == null && y == null) return true;

                return x.age ==y.age;
            }

            public int GetHashCode([DisallowNull] Empolyee obj)
            {
                return obj.age.GetHashCode();
            }
        }
        class Empolyee
        {
            public string name { get; set; }
            public int age { get; set; }
            public decimal salary { get; set; }

            public override bool Equals(object? obj)
            {
                Empolyee? other = obj as Empolyee;

                if (other == null) return false;

                return this.salary == other.salary;

            }
            public override int GetHashCode()
            {
                return HashCode.Combine(salary);
            }
            public override string ToString()
            {
                return $"emp: {this.name}";
            }
        }
        static void Main(string[] args)
        {

            Empolyee[] eArr =
            {
                new Empolyee() {name = "ali", age = 22,salary = 15000 },
                new Empolyee() {name = "ahmed", age = 42,salary = 15000 },
                new Empolyee() {name = "mona", age = 42,salary = 10000 },
                new Empolyee() {name = "joo", age = 42,salary = 10000 }

            };


            var result = from e in eArr
                         group e by e.salary
                         into category
                         select category;

            


            foreach (var e in result)
            {
                Console.WriteLine(e);
                foreach (var emp in e)
                {
                    Console.WriteLine(emp);
                }

            }
        }
    }
}
