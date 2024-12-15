using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class Utility
    {
        //public static void Sort3DPoints(Point3D[] point) {
        //    for (int i = 0; i < point.Length; i++) 
        //    {
        //        for(int j = 0; j < point.Length-1; j++)
        //        {
        //            if (point[i].X > point[j].X)
        //                (point[i], point[j]) = (point[j], point[i]);
        //            else if (point[i].X == point[j].X)
        //                if(point[i].Y > point[j].Y)
        //                    (point[i], point[j]) = (point[j], point[i]);
        //        }
        //    }
        //}
        public static void LogError(Exception ex)
        {
            string logFilePath = @"C:\Users\hashe\Desktop\myworkspace\iti\CSharp\Labs\logs.txt";
            string logMessage = $"{ex.Message}";

            try
            {
                File.AppendAllText(logFilePath, logMessage);
                Console.WriteLine("Error logged to file.");
            }
            catch (Exception fileEx)
            {
                Console.WriteLine("Failed to write to log file: " + fileEx.Message);
            }
        }
    }
}
