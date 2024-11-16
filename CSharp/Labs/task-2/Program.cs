using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            //part1.generateMultiplicationTable2D();
            //part1.studentHelper(2, 3);

            //Rectangle r = new Rectangle();
            //r.Width = 2;
            //r.Height = 3;

            //Console.WriteLine($"area = {r.getArea()}");
            //Console.WriteLine($"perimeter = {r.getPerimeter()}");
            //Console.WriteLine(r.ToString());
            #endregion

            #region TimeSpan
            //TimeSpan t = new TimeSpan();
            //t.Hours = 3;
            //t.Minutes = 30;
            //t.Seconds = 20;

            //Console.WriteLine(t.ToString());
            //Console.WriteLine($"total seconds: {t.getTotalSeconds()}");
            #endregion

            #region arrayOfTimeSpan
            //  Fill timeSpan Array
            Console.WriteLine("enter length of timeSpan array");
            int len = int.Parse(Console.ReadLine());
            TimeSpan[] tArr = new TimeSpan[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"hours for timeSpan {i + 1}: ");
                tArr[i].Hours = int.Parse(Console.ReadLine());
                Console.WriteLine($"minutes for timeSpan {i + 1}: ");
                tArr[i].Minutes = int.Parse(Console.ReadLine());
                Console.WriteLine($"seconds for timeSpan {i + 1}: ");
                tArr[i].Seconds = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("********** UnSorted Array **********"); 
            for (int i = 0; i < len; i++)
            {   
                Console.WriteLine(tArr[i].ToString());
            }

            Console.WriteLine("********** Sorted Array **********");
            Utility.sortTimeSpan(tArr);
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(tArr[i].ToString());
            }


            #endregion

            #region jaggedArray
            //jagged
            //part1.studentHelperv2
            #endregion
        }
    }
}
