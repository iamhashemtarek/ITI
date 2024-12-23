--Part-2: Use AdventureWorks DB
use AdventureWorks2012;

--⦁	Display the SalesOrderID, ShipDate of the SalesOrderHeader table
--(Sales schema) to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
select SalesOrderID, ShipDate
from Sales.SalesOrderHeader
where ShipDate between '7/28/2002' and '7/29/2014'

--⦁	Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID, Name, StandardCost
from Production.Product
where StandardCost < 110.00

--⦁	Display ProductID, Name if its weight is unknown
select ProductID, Name
from Production.Product
where Weight is not null

--⦁	 Display all Products with a Silver, Black, or Red Color
select *
from Production.Product
where Color in  ('Silver', 'Black', 'Red')

--⦁	 Display any Product with a Name starting with the letter B
select Name
from Production.Product
where LEFT(Name, 1) = 'B'

--⦁	Run the following Query
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3
--Then write a query that displays any Product description with underscore value in its description.
select Description 
from Production.ProductDescription
where CHARINDEX('_', Description, 1) > 0

--⦁	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2014'
select sum(TotalDue)
from Sales.SalesOrderHeader
where OrderDate between '7/1/2001' and '7/31/2014'
group by OrderDate

--⦁	 Display the Employees HireDate (note no repeated values are allowed)
select distinct HireDate
from HumanResources.Employee

--⦁	 Calculate the average of the unique ListPrices in the Product table
select AVG(distinct ListPrice)
from Production.Product

--⦁	Display the Product Name and its ListPrice within the values of 100 and 120
--the list should has the following format "The [product name] is only! [List price]" 
--(the list will be sorted according to its ListPrice value)
select 'The ' + Name + ' os only! ' + cast(ListPrice as varchar)
from Production.Product
where ListPrice between 100 and 120
	

--⦁	 Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table  in a newly created table named [store_Archive]
--Note: Check your database to see the new table and how many rows in it?
select rowguid ,Name, SalesPersonID, Demographics 
into store_archive
from Sales.Store

--⦁	Try the previous query but without transferring the data? 
select rowguid ,Name, SalesPersonID, Demographics 
into store_archive
from Sales.Store
where 1 = 2;

--⦁	Using union statement, retrieve the today’s date in different styles using convert or format funtion. 
SELECT convert(varchar, getdate(), 1) AS DateStyle1 -- MM/DD/YYYY
UNION
SELECT convert(varchar, getdate(), 3) AS DateStyle2 -- DD/MM/YYYY
UNION
SELECT convert(varchar, getdate(), 4) AS DateStyle3 -- DD.MM.YY
UNION
SELECT format(getdate(), 'yyyy-MM-dd') AS DateStyle4 -- ISO 8601 format (yyyy-MM-dd)
UNION
SELECT format(getdate(), 'dddd, MMMM dd, yyyy') AS DateStyle5 -- Full date with day and month name
