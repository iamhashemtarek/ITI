using System;

namespace task_2
{
    internal class Utilitys
    {
        public static void sortTimeSpan(TimeSpan[] timeSpanArr)
        {
            for(int i = 0; i < timeSpanArr.Length-1; i++)
            {
                if (timeSpanArr[i].getTotalSeconds() > timeSpanArr[i+1].getTotalSeconds())
                {
                    //TimeSpan temp = timeSpanArr[i + 1];
                    //timeSpanArr[i + 1] = timeSpanArr[i];
                    //timeSpanArr[i] = temp;

                    (timeSpanArr[i], timeSpanArr[i+1]) = (timeSpanArr[i+1], timeSpanArr[i]);
                }
            }
        }
    }
}
