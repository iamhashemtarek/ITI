namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialInsurance socialInsurance = new SocialInsurance();
            Club club = new Club();

            Employee emp1 = new Employee("hashem", 24);
            Employee emp2 = new Employee("ali", 22);
            Employee emp3 = new Employee("mona", 20);
            Employee emp4 = new Employee("joo", 30);

            socialInsurance.Subscribe(emp1);
            socialInsurance.Subscribe(emp2);
            socialInsurance.Subscribe(emp3);
            socialInsurance.Subscribe(emp4);

            club.Subscribe(emp1);
            club.Subscribe(emp2);
            club.Subscribe(emp3);
            club.Subscribe(emp4);


            emp1.addEmployee();
            emp2.addEmployee();
            emp3.addEmployee();
            emp4.addEmployee();


            //emp1.Age = 61;


            Console.WriteLine(socialInsurance.ToString());
            Console.WriteLine(club.ToString());

            emp1.Age = 61;
            Console.WriteLine(socialInsurance.ToString());

        }
    }
}
