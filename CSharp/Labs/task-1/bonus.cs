using System;

namespace task_1
{
    internal class bonus
    {
        public static int getSumOfAllElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int getMaxElement(int[] arr) 
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) 
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        public static void reverseArrayInPlace(int[] arr) { 
            for (int i = 0; i < arr.Length/2; i++)
            {
                (arr[i],  arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);    
            }
        }
        public static int getCountOfSpecifiedElement(int[] arr, int elem) { 
            int count = 0;
            for(int i  = 0; i < arr.Length; i++)
            {
                if(elem == arr[i])
                {
                    count++;
                }
            }

            return count;
        }
        public static int removeDuplicatesFromArrayInPlace(int[] arr)
        {
            Array.Sort(arr);

            int idx = 1;

            for(int i=0; i < arr.Length-1; i++)
            {
                    if (arr[i] != arr[i+1])
                {
                    arr[idx++] = arr[i+1];
                }

            }
            return idx;
        }
        public static int getSecondLargestElement(int[] arr)
        {
            int idx = removeDuplicatesFromArrayInPlace(arr);
            return arr[idx-2];
        }
        public static int getIndexOfMinimumValue(int[] arr)
        {
            int min = arr[0];
            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i; ;
                }
            }

            return minIndex;
        }
    }
}
