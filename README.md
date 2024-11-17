# CSharp tasks

## Task 1

### Part 1

1. Write a program to take a character from the user and display its ASCII code.
2. Write a program to convert an ASCII code back to its corresponding character.
3. Write a program to take a number from the user and display whether it is odd or even.
4. Write a program to take two numbers from the user and print their sum, subtraction, and multiplication.
5. Write a program to take a student's grade and calculate their final letter grade.
6. Write a program to generate and print a multiplication table.

---

### Part 2

1. **Store Students' Grades:**
   - Take the number of students and their grades from the user.
   - Print the grades.
   - Calculate the average of all students' grades.

2. **Find Longest Distance in an Array:**
   - Given an array of integers, write a program to find the longest distance between two equal cells. 
   - Example:  
     Input: `7 0 0 0 5 6 7 5 0 7 5 3`  
     Output: Longest distance is between the first and the 10th `7`, with a distance of 8 cells.

#### Notes:
- The array values will be taken from the user.
- For input like `1111111`, the distance is the number of cells between the first and the last occurrence.

---

### Bonus

Given an integer array, implement the following programs:

1. Calculate the sum of all elements.
2. Find the maximum element.
3. Reverse the array without using built-in reverse functions.
4. Count the occurrences of a specific element.
5. Remove duplicate elements.
6. Find the second-largest element.
7. Find the index of the minimum element.

---

#### Additional Challenge:

Count the occurrences of the digit `1` from `1` to `99,999,999` (just below 100 million):

1. Use string conversion and functions to count the `1`s.
2. Use only mathematical operations and numeric values to calculate the same.
3. Compare the performance of both approaches.

### Bonus Question:
Can you optimize this to compute the result in approximately 1 second or less?

---

## Task 2

### Part 1

1. **Multiplication Table:**
   - Write a program to generate a multiplication table using a 10x10 two-dimensional array.
     - Declare and initialize the array.
     - Fill the array so that the element at `[i, j]` equals `(i + 1) * (j + 1)`.
     - Print the multiplication table.

2. **Store Student Ages for Multiple Tracks:**
   - Take the number of students and tracks from the user.
   - Enter the ages of students.
   - Print the array of ages.
   - Calculate the average age for each track.

#### Bonus:
- Handle cases where the number of students differs for each track.

---

### Part 2

1. **Rectangle Structure:**
   - Define a `struct` named **Rectangle** with properties `Width` and `Height`.
   - Add the following:
     - Getter and setter methods.
     - Methods to calculate the area (`Area`) and perimeter (`Perimeter`).
     - A method `GetString` to display the rectangle's dimensions as a string.

2. **TimeSpan Structure:**
   - Define a `struct` named **TimeSpan** with properties `Hours`, `Minutes`, and `Seconds`.
   - Add the following:
     - Getter and setter methods.
     - A method `TotalSeconds` to calculate the total time span in seconds.
     - A method `GetString` to display the time span in `HH:MM:SS` format.
     - Create an array of time spans, take its size and data from the user, and print the array.

#### Bonus:
- Attempt to sort the array using a built-in `sort` function.
- If that doesn’t work, implement your own sorting function.

---

## Task 3

### Part 1: Employee Management

1. **Employee Class:**
   - Each employee has the following properties:
     - `ID`
     - `Salary`
     - `Hire Date` (a custom `HireDate` structure with fields `Day`, `Month`, `Year`)
     - `Gender`
   - Provide methods to:
     - Represent employee data as a string.
     - Sort employees by hire date.
   - Create an array of employees, where the size is determined by user input.

2. **Implementation Requirements:**
   - Use properties instead of getters and setters.
   - Define all necessary constructors.
   - Sort the employees array by hire date and print the sorted array.

---

### Part 2: Question Object Design

1. **Question Class:**
   - Define a base class for a question with the following properties:
     - `Body`
     - `Marks`
     - `Header`
   - Create the following question types as derived classes:
     - `True or False`
     - `Choose One`
     - `Choose All`
   - Each type should have a unique representation.

2. **Implementation Requirements:**
   - Use properties instead of getters and setters.
   - Define all necessary constructors.
   - Provide methods to represent question data as a string.

3. **Array of Questions:**
   - Create an array that accepts only `True or False`, `Choose One`, and `Choose All` question types.
