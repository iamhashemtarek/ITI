using System;

namespace task_4
{
    internal static class Math
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Subtract(int a, int b) { return a - b; }
        public static int Multiply(int a, int b) {return a * b; }
        public static double Divide(int a, int b) 
        { 
            return b == 0 ? throw new Exception("Divisor couldn't be 0") : (double)a / b;
        }
    }
}
