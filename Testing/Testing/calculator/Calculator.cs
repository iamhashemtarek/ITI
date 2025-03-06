using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public bool IsEven(int number) => number % 2 == 0;

        public string Greet(string name) => $"Hello, {name}!";

        public int[] GetEvenNumbers(int max)
        {
            var evens = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0) evens.Add(i);
            }
            return evens.ToArray();
        }

        public int Add(int a, int b) => a + b;

        public object GetResultAsObject(bool returnNumber)
        {
            return returnNumber ? 42 : "Not a number";
        }

        public object GetReference(bool returnNull)
        {
            return returnNull ? null : this;
        }


    }
}
