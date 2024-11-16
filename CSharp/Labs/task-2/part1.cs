using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class part1
    {
        public static void generateMultiplicationTable2D()
        {
            int[,] arr = new int[10, 10];
            for(int i= 0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j<arr.GetLength(1); j++)
                {
                    arr[i, j] = ((i + 1) * (j + 1));
                }
            }

             for(int i = 0; i < arr.GetLength(0); i++)
             {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine("\n");
             }
        }
        public static void studentHelper(int numberOfTracks, int numberOfStudents)
        {
            int[,] studentAges = new int[numberOfTracks, numberOfStudents];

            //take ages from user
            for(int i = 0; i<numberOfTracks; i++)
            {
                for(int j = 0; j<numberOfStudents; j++)
                {
                    Console.WriteLine($"enter age of student-{j+1} in track {i + 1}");
                    studentAges[i, j] = int.Parse(Console.ReadLine()); 
                }
            }

            //print studentAges arr
            double[] sumOfAgesPerTrack = new double[numberOfTracks];
            for(int i = 0; i<studentAges.GetLength(0); i++)
            {
                for(int j = 0; j<studentAges.GetLength(1); j++)
                {
                    sumOfAgesPerTrack[i] += studentAges[i, j];
                    Console.Write($"{studentAges[i, j]} ");
                }
                Console.WriteLine($"average of ages per track {i + 1}: {(sumOfAgesPerTrack[i] /numberOfStudents)}");
                Console.WriteLine("\n");
            }
        }
        public static void studentHelperv2()
        {
            Console.WriteLine("enter number of tracks: ");
            int tracksNumber = int.Parse(Console.ReadLine());
            int[] stduentsNumberPerTrack = new int[tracksNumber];
            for( int i = 0; i < stduentsNumberPerTrack.Length; i++)
            {
                Console.WriteLine($"enter student number per track {i + 1}");
                stduentsNumberPerTrack[i] = int.Parse(Console.ReadLine());
            }

            int[][] ages = new int[tracksNumber][];
            for(int i = 0; i< tracksNumber; i++)
            {
                ages[i] = new int[stduentsNumberPerTrack[i]];   
            }

            //get ages
            for(int i = 0; i<tracksNumber; i++)
            {
                for(int j = 0; j < stduentsNumberPerTrack[i];j++)
                {
                    Console.WriteLine($"age of student {j + 1} in track {i + 1}");
                    ages[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < tracksNumber; i++)
            {
                int sum = 0;
                Console.Write($"track {i + 1} ages: ");
                for (int j = 0; j < stduentsNumberPerTrack[i]; j++)
                {
                    Console.Write($"{ages[i][j]} ");
                    sum += ages[i][j];
                }
                Console.WriteLine();
                Console.WriteLine($"average of ages in track {i + 1}: {sum / stduentsNumberPerTrack[i]}");
            }

        }
    }
}
