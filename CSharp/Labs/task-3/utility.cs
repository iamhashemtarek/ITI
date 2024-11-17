using System;


namespace task_3
{
    internal class utility
    {
        public static void sort(Employee[] employeeArr)
        {
            for(int i = 0; i < employeeArr.Length-1; i++)
            {
                if (employeeArr[i].getHiringDateInSec() > employeeArr[i+1].getHiringDateInSec())
                {
                    (employeeArr[i], employeeArr[i + 1]) = (employeeArr[i + 1], employeeArr[i]);
                }
            }
        }

        public static void sortV2(Employee[] employeeArr) 
        { 
            for( int i = 0; i < employeeArr.Length-1; i++)
            {
                if (employeeArr[i].HiringDate.Year > employeeArr[i+1].HiringDate.Year)
                    (employeeArr[i], employeeArr[i + 1]) = (employeeArr[i + 1], employeeArr[i]);
                else if (employeeArr[i].HiringDate.Year == employeeArr[i + 1].HiringDate.Year) 
                    if(employeeArr[i].HiringDate.Month > employeeArr[i + 1].HiringDate.Month)
                        (employeeArr[i], employeeArr[i + 1]) = (employeeArr[i + 1], employeeArr[i]);
                    else if (employeeArr[i].HiringDate.Month == employeeArr[i + 1].HiringDate.Month) 
                            if(employeeArr[i].HiringDate.Day > employeeArr[i + 1].HiringDate.Day)
                              (employeeArr[i], employeeArr[i + 1]) = (employeeArr[i + 1], employeeArr[i]);

            }
        }

    }
}
