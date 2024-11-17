namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            //Employee emp = new Employee(1, 15000, Gender.male, new HiringDate(17, 11, 2024));
            //Console.WriteLine(emp.ToString());

            //Console.WriteLine("enter the number of the employees: ");
            //int numberOfEmployee = int.Parse(Console.ReadLine());
            //Employee[] empArr = new Employee[numberOfEmployee];
            //for(int i = 0; i<empArr.Length; i++)
            //{
            //    Console.WriteLine($"employee {i + 1} id: ");
            //    int tempId = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"employee {i + 1} salary: ");
            //    int tempSalary = int.Parse(Console.ReadLine());

            //    Console.WriteLine("employee {i+1} gender (male | female): ");
            //    string tempGender = Console.ReadLine();

            //    Console.WriteLine("employee {i+1} hiring date seperated by a space (day month year): ");
            //    string tempHireDate = Console.ReadLine();

            //    Gender gender;
            //    if (tempGender == "male")
            //        gender = Gender.male;
            //    else

            //        gender = Gender.female;

            //    string[] arrTempHireDate = tempHireDate.Split(" ");
            //    HiringDate hiringDate = new HiringDate(int.Parse(arrTempHireDate[0]), int.Parse(arrTempHireDate[1]), int.Parse(arrTempHireDate[2]));

            //    //creation
            //    empArr[i] = new Employee(tempId, tempSalary , gender, hiringDate);

            //}

            //sorting employee arr
            //utility.sort(empArr);

            //utility.sortV2(empArr);

            //for (int i = 0; i < empArr.Length; i++) 
            //{
            //    Console.WriteLine(empArr[i].ToString());    
            //}
            #endregion

            #region part2
            //Question q = new Question("true or false", 4, "c# supports multipile inheritance.");
            //Console.WriteLine(q.getQuestionDetails());

            //Question q2 = new TrueOrFalseQuestion(4, "c# supports multipile inheritance.", true);
            //Console.WriteLine(q2.getQuestionDetails());

            //Question q3 = new ChooseOneQuestion(4, "c# supports multipile inheritance.", ["option1", "option2", "option3"], "option1");
            //Console.WriteLine(q3.getQuestionDetails());

            //Question q4 = new chooseAllQuestion(4, "c# supports multipile inheritance.", ["option1", "option2", "option3"], ["option1", "option2"]);
            //Console.WriteLine(q4.getQuestionDetails());

            Question[] questionArr = new Question[3];
            questionArr[0] = new TrueOrFalseQuestion(4, "c# supports multiple inheritance.", false); 
            questionArr[1] = new ChooseOneQuestion(5, "c# supports multipile inheritance.", ["option1", "option2", "option3"], "option1");
            questionArr[2] = new chooseAllQuestion(6, "c# supports multipile inheritance.", ["option1", "option2", "option3"], ["option1", "option2"]);

            for (int i = 0; i < questionArr.Length; i++) 
            {
                Console.WriteLine($"----question no.{i+1}: \n {questionArr[i].getQuestionDetails()}");
            }

            #endregion
        }
    }
}
