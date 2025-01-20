namespace myspace
{
    public delegate int stringFuncDelegate(string s);
    public delegate bool CompareFuncDel(int x, int y);
    //public delegate bool ConditionDel(int num);
    internal class Program
    {
            
        static void Main(string[] args)
        {

            #region delegate
            //mydel += StringFunctions.getNumOfUpperCaseChar;

            //int result = mydel("Hashem Tarek");

            //Console.WriteLine(result);

            //int[] arr = { 3, 5 ,4 , 1, 9 };
            //CompareFuncDel compareFuncDel = CompareFunctions.CompareGrt;
            //SortingAlgorithms.BubbleSort(arr, compareFuncDel);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //List<int> list = Enumerable.Range(0, 100).ToList();
            //List<int> evenNum = NumberFunctions.FindNumber(list, (num) => num % 2 == 0);
            //List<int> OddNum = NumberFunctions.FindNumber(list, (num) => num % 2 == 1);
            //List<int> DivisbleBySeven = NumberFunctions.FindNumber(list, (num) => num % 7 == 0);
            //foreach (int x in evenNum)
            //{
            //    Console.Write($"{x} ");
            //}

            //List<string> list = new List<string>()
            //{
            //    "hashem",
            //    "tarek",
            //    "tasneem",
            //    "doaa",
            //    "taleen"
            //};

            //List<String> result = list.FindAll(item => item.Length >= 6);
            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region extention method

            int num = 12345;
            int reversedNum = num.reverse();
            Console.WriteLine($"reversed num: {reversedNum}");
            #endregion

        }
    }

    class StringFunctions
    {
        public static int getNumOfLowerCaseChar(String str)
        {
            int counter = 0;

            if (!string.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                    if (char.IsLower(c))
                        counter++;
                }
            }

            return counter;
        }
        public static int getNumOfUpperCaseChar(String str)
        {
            int counter = 0;

            if (!string.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                    if (char.IsUpper(c))
                        counter++;
                }
            }

            return counter;
        }
    }
    class SortingAlgorithms 
    {
        public static void BubbleSort(int[] arr, CompareFuncDel compareFunc)
        {
            if (arr is not null && compareFunc is not null)
            {
                for(int i=0; i<arr.Length; i++)
                {
                    for(int j = 0; j<arr.Length-i-1; j++)
                    {
                        if (compareFunc(arr[j], arr[j+1]))
                            (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    }
                }
            }
        }
    }
    class CompareFunctions
    {
        public static bool CompareGrt(int x, int y) => x > y; //ascending
        public static bool CompareLess(int x, int y) => x < y; //descending
    }
    static class NumberFunctions
    {
        public static List<int> FindNumber(List<int> numbers, Predicate<int> conditionDel)
        {
            List<int> result = new List<int>(); 

            if (numbers is not null && conditionDel is not null)
            {
                foreach (int item in numbers)
                {
                    if (conditionDel(item))
                        result.Add(item);
                } 
            }

            return result;
        }
        public static int reverse(this int num)
        {
            int result = 0;
            int remainder;

            while (num != 0) 
            {
                remainder = num % 10;
                result = result * 10 + remainder;
                num = num /10;
            }

            return result;
        
        }
    }

}