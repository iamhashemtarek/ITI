namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Math
            //Console.WriteLine(Math.Add(1,2));
            //Console.WriteLine(Math.Subtract(1, 2));
            //Console.WriteLine(Math.Multiply(1, 2));
            //Console.WriteLine(Math.Divide(1, 2));
            #endregion

            #region Duration
            Duration d1 = new Duration(10, 30, 10);
            Duration d2 = new Duration(7800);
            Duration d3 = new Duration(7800);

            Console.WriteLine($"d1 -> {d1}");
            Console.WriteLine($"d2 -> {d2}");
            Console.WriteLine((d3 >= d2));
            #endregion
        }
    }
}
