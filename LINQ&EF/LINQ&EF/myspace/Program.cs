using myspace.Contexts;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace myspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using testDbContext dbContext = new testDbContext();

            var E01 = new Employee()
            {
                Name = "hashem",
                Salary = 100000,
                Age = 24,
                Address = "hashemtarek2012@gmail.com",
                PhoneNumber = "123",
                Password = "123",
            };
            var E02 = new Employee()
            {
                Name = "hashem",
                Salary = 100000,
                Age = 70,
                Address = "hashemtarek2012@gmail.com",
                PhoneNumber = "123",
                Password = "123",
            };

            //Console.WriteLine(dbContext.Entry(E02).State);

            //dbContext.Employees.Add(E02);

            //Console.WriteLine(dbContext.Entry(E02).State);

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(E02).State);

            var result = dbContext.Employees.Where(e => e.Id == 50).SingleOrDefault();
            Console.WriteLine(result is not null ? result : "NA");

        }
    }
}
