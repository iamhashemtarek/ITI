namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, 2000, Gender.male, new HiringDate(15, 1, 2024), Privilage.developer);
            Employee emp1 = new Employee(2, 3000, Gender.female, new HiringDate(15, 12, 2024), Privilage.guest);
            Employee emp2 = new Employee(3, 1500, Gender.male, new HiringDate(15, 12, 2024), Privilage.secretary);
            Employee emp3 = new Employee(4, 1500, Gender.female, new HiringDate(1, 1, 2023), Privilage.DBA);
            Employee master = new Employee(5, 1000, Gender.male, new HiringDate(2, 8, 2024), Privilage.secretary ^ Privilage.guest ^ Privilage.developer ^ Privilage.DBA);

            Employee[] arrOfEmployees = new Employee[] {emp, emp1, emp2, emp3, master };

            Utility.printArrOfEmployees(arrOfEmployees);

            Array.Sort(arrOfEmployees); Console.WriteLine("------------------------------------");

            Utility.printArrOfEmployees(arrOfEmployees);
            ;
        }
    }
}
