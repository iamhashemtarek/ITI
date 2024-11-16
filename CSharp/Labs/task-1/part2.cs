using System;


namespace task_1
{
    internal class part2
    {
        public static void getAllGradesAndTheAverage()
        {

            // get the num of studnets
            Console.WriteLine("enter the number of students");
            string studentNumberInput = Console.ReadLine();

            int studentNumber = 0;
            try
            {
                studentNumber = int.Parse(studentNumberInput);
                if(studentNumber <=0)
                {
                    throw new Exception();
                }
            }
            catch (Exception e) { 
                Console.WriteLine("invalid input. please enter a valid number greater than 0");
            }

            string[] studentNames = new string[studentNumber];
            double[] studentGrades = new double[studentNumber];

            //take student name and grade from user
            for (int i = 0; i < studentNumber; i++)
            {
                Console.WriteLine($"enter student {i + 1} name: ");
                studentNames[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(studentNames[i]))
                {
                    Console.WriteLine("invalid input. don't leave student name field empty");
                    return;
                }

                Console.WriteLine($"enter student {i+1} grade: ");
                try
                {
                    studentGrades[i] = int.Parse(Console.ReadLine());
                    if (studentGrades[i] < 0 || studentGrades[i] > 100)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid input. please enter a valid grade in range of 0 to 100");
                }
            }

            //print grades
            Console.WriteLine("\n***** student grades *****");
            for (int i = 0;i < studentNumber;i++) 
            {
                Console.WriteLine($"{studentNames[i]}: {studentGrades[i]}");
            }

            //calc and print avg
            Console.WriteLine("\n***** average of grades *****");
            double sum = 0;
            for(int i = 0; i< studentNumber; i++)
            {
                sum += studentGrades[i];
            }
            Console.WriteLine($"the avg grade of all students is: {sum / studentNumber}");

        }
        public static int findLongestDistance(int[] arr) {
            int idx = 0;
            int maxDistance = -1;
            int currentDistance = -1;

            for (int i = arr.Length-1; i >0; i--)
            { 
                if (arr[idx] == arr[i])
                {
                    currentDistance = i - idx -1;
                    if(currentDistance > maxDistance)
                    {
                        maxDistance = currentDistance;
                    }
                    idx++;
                }
            }

            return maxDistance;
        }
    }
}
