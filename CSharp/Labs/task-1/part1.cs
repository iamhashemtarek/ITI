using System;

namespace task_1
{
    internal class part1
    {
        public static void printAsciiOfChar()
        {
            Console.WriteLine("enter a character: ");
            string userInput = Console.ReadLine();

            if (userInput == null || userInput.Length != 1) {
                Console.WriteLine("invalid input. please enter a single character");
                return;
            }

            char inputChar = (char)userInput[0];
            int asciiOfChar = (int)inputChar;


            Console.WriteLine($"the ascii for {inputChar} is: {asciiOfChar}");
        }
        public static void printCharFromAscii() {
            Console.WriteLine("enter an ascii code");
            string userInput = Console.ReadLine();

            int asciiCode;

            try
            {
                asciiCode = int.Parse(userInput);

                if(asciiCode >= 0 && asciiCode <= 255)
                {
                    char character  = (char)asciiCode;
                    Console.WriteLine($"the character for ascii {asciiCode} is: {character}");
                }else
                {
                    Console.WriteLine("invalid input. please enter an ascii in range from 0 to 255");
                }
            }
            catch (Exception e) {
                Console.WriteLine("invalid input. please enter a valid ascii");
            }
        }
        public static  void printIfNumIsEvenOrOdd()
        {
            Console.WriteLine("enter a number: ");
            string userInput = Console.ReadLine();

            try
            {
                double num = double.Parse(userInput);

                if(num %2 == 0) {
                    Console.WriteLine("the number u entered is even");
                } else
                {
                    Console.WriteLine("the number u entered i odd");
                }
            }
            catch (Exception e) {
                Console.WriteLine("invalid input. please enter a valid number");
            }
        }
        public static void printSumAndSubtractionAndMultiplication(int num1, int num2) { 
            Console.WriteLine($"{num1} + {num2} = {num1+ num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        public static void printGrade(double degree)
        {
            if( degree < 0  || degree > 100)
            {
                Console.WriteLine("degree must be in range of 0 to 100");
                return;
            }

            if(degree >= 95)
            {
                Console.WriteLine("your grade is: A+");
            }else if (degree >=90)
            {
                Console.WriteLine("your grade is: A");
            }
            else if (degree >=85)
            {
                Console.WriteLine("your grade is: B+");
            }else if (degree >= 80)
            {
                Console.WriteLine("your grade is: B");
            }
            else if (degree >=75)
            {
                Console.WriteLine("your grade is: C+");
            }
            else if ( degree >= 70)
            {
                Console.WriteLine("your grade is: C");
            }
            else if (degree >=65)
            {
                Console.WriteLine("your grade is: D+");
            }
            else if (degree >= 60)
            {
                Console.WriteLine("your grade is: D");
            }
            else
            {
                Console.WriteLine("your grade is: F");
            }
        }
        public static void printMultiplicationTable(int num)
        {
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine($"{i} * {num} = {i*num}");
            }
        }


    }
}
