using static day02.ListGenerators;
namespace day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
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

            #region Q2
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

            //Query 3

            //1. Find the unique Category names from Product List
            //var q1 = ProductList.Select(product => product.Category).Distinct();
            //foreach (var productName in q1)
            //{
            //    Console.WriteLine(productName);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            var q1 = ProductList.Select(product => product.ProductName[0]).Distinct();
            var q2 = CustomerList.Select(customer => customer.CompanyName[0]).Distinct();
            var q3 = q1.Union(q2);
            foreach (var item in q3) 
            {
                Console.WriteLine(item);
            }

            //3. Create one sequence that contains the common first letter from both product and customer names.

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates

        }
    }
}
