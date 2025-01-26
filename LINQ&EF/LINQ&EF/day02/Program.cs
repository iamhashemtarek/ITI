using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static day02.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region myspace

            //var seq = CustomerList.Where(customer => customer.Orders.Length >100).Single();
            //Console.WriteLine(seq == null);




            #endregion

            #region Restriction Operators

            //Query 1

            //1. Find all products that are out of stock.
            //var q1 = ProductList.Where(product => product.UnitsInStock == 0);
            //foreach (var product in q1)
            //{
            //    Console.WriteLine(product);
            //}

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var q2 = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3);
            //foreach (var product in q2)
            //{
            //    Console.WriteLine(product);
            //}

            //3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var q3 = Arr.Where((digit, idx) => idx > digit.Length);
            //foreach (var i in q3)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Restriction Operators

            //Query 2

            //1. Get first Product out of Stock 
            //var firstProduct = ProductList.Where(product => product.UnitsInStock ==0).FirstOrDefault();
            //Console.WriteLine(firstProduct);

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var firstProduct = ProductList.Where(product => product.UnitPrice > 1000).FirstOrDefault();

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumber = Arr.Where(num => num > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secondNumber); 
            #endregion

            #region Set Operators

            //Query 3

            //1. Find the unique Category names from Product List
            //var q1 = ProductList.Select(product => product.Category).Distinct();
            //foreach (var productName in q1)
            //{
            //    Console.WriteLine(productName);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var q1 = ProductList.Select(product => product.ProductName[0]).Distinct();
            //var q2 = CustomerList.Select(customer => customer.CompanyName[0]).Distinct();
            //var q3 = q1.Union(q2);
            //foreach (var item in q3) 
            //{
            //    Console.WriteLine(item);
            //}

            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var q1 = CustomerList.Select(customer => customer.CompanyName[0]).Distinct();
            //var q2 = ProductList.Select(product => product.ProductName[0]).Distinct();
            //var q3 = q1.Intersect(q2);
            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var q1 = CustomerList.Select(customer => customer.CompanyName[0]).Distinct();
            //var q2 = ProductList.Select(product => product.ProductName[0]).Distinct();
            //var q3 = q2.Except(q1);
            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //}


            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            //var q1 = CustomerList
            //    .Select(customer => customer.CompanyName.Length > 3
            //    ? customer.CompanyName.Substring(customer.CompanyName.Length - 3) 
            //    : customer.CompanyName);

            //var q2 = ProductList
            //    .Select(product => product.ProductName.Length > 3
            //    ? product.ProductName.Substring(product.ProductName.Length -3 )
            //    : product.ProductName);


            //var q3 = q1.Concat(q2);

            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

            #region Aggregate Operators
            //Query 4

            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(elem => elem % 2 == 1); 
            //Console.WriteLine(result);

            //Use ListGenerators.cs & Customers.xml
            //2.Return a list of customers and how many orders each has.
            //var result = CustomerList
            //    .Select(customer => new
            //    {
            //        Name = customer.CompanyName,
            //        CountOfOrder = customer.Orders.Length,
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Return a list of categories and how many products each has
            //var result = ProductList
            //    .GroupBy(product => product.Category)
            //    .Select(category => new
            //    {
            //        Category = category.Key,
            //        CountOfProducts = category.Count()
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 

            //4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////var result = Arr.Aggregate((x, y) => x + y);
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //6.Get the total units in stock for each product category.
            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(p => new
            //    {
            //        Category = p.Key,
            //        UnitsInStock = p.Sum(p => p.UnitsInStock)
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //8.Get the cheapest price among each category's products
            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(p => new
            //    {
            //        Category = p.Key,
            //        CheapestPrice = p.Min(p => p.UnitPrice),
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //9.Get the products with the cheapest price in each category(Use Let)

            //10.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //11.Get the most expensive price among each category's products.

            //12.Get the products with the most expensive price in each category.
            //13.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //14.Get the average price of each category's products.

                #endregion



            }
    }
}
 