CREATE DATABASE ASS1_SQLSVR_DB;

USE ASS1_SQLSVR_DB;

CREATE TABLE Sales_Raw(
OrderID INT,
OrderDate VARCHAR(20),
CustomerName VARCHAR(100),
CustomerPhone VARCHAR(20),
CustomerCity VARCHAR(50),
ProductNames VARCHAR(100),
Quantities VARCHAR(100),
UnitPrices VARCHAR(100),
SalesPerson VARCHAR(100));

INSERT INTO Sales_Raw VALUES
(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai','Laptop,Mouse', '1,2', '55000,500', 'Anitha'),
(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore','Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),
(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai','Laptop', '1', '54000', 'Suresh'),
(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad','Monitor,Mouse', '1,1', '12000,500', 'Anitha'),
(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore','Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');

SELECT * FROM Sales_Raw;

--Question 1 Normalization

CREATE TABLE Customers(
CustomerID int primary key,
CustomerName Varchar(50),
CustomerPhone Varchar(10),
CustomerCity Varchar(30)
);


CREATE TABLE Products(
ProductID int primary key,
ProductName Varchar(30),
UnitPrices int
);

CREATE TABLE SalesPersons(
SalesPersonID int primary key,
SalesPersonName Varchar(30)
);

CREATE TABLE Orders(
OrderID int primary Key,
OrderDate Varchar(15),
CustomerID int,
SalesPersonID int,
Foreign Key (CustomerID) references Customers(CustomerID),
Foreign Key (SalesPersonID) references SalesPersons(SalesPersonID)
);

CREATE TABLE OrderDetails(
OrderDetailID int Identity Primary key,
OrderID int,
ProductID int,
Quatity int not null,
Foreign Key (ProductID) references Products(ProductID),
Foreign Key (OrderID) references Orders(OrderID)
);


INSERT INTO Customers VALUES(1,'Ravi Kumar','9876543210','Chennai'),
(2,'Priya Sharma','9123456789','Banglore'),
(3,'Naina Singh','9798934323','Delhi'),
(4,'Suryansh Shukla','8755896556','Auraiya'),
(5,'Devesh Singh','9084174826','Auraiya');

INSERT INTO Products VALUES(1,'Laptop',55000),
(2,'Mouse',500),
(3,'Keyboard',1500),
(4,'Monitor',12000),
(5,'Gaming Laptop',96000);

INSERT INTO SalesPersons VALUES(1,'Anitha'),
(2,'Suresh');

INSERT INTO Orders VALUES (101,'2024-01-05',1,1),
(102,'2024-01-06',2,1),
(103,'2024-01-10',3,2),
(104,'2024-02-01',4,1),
(105,'2024-02-10',5,2);

INSERT INTO OrderDetails VALUES(101,1,1),
(101,2,2),
(102,3,1),
(102,2,1),
(103,5,1),
(104,4,2),
(104,2,2),
(105,1,2),
(105,3,5);

--Question 2 Third Highest Total Sales

--SELECT C.CustomerID, C.CustomerName, O.OrderID,
--O.OrderDate, P.ProductID, P.ProductName,SP.SalesPersonName,P.UnitPrices, 
--OD.Quatity, (P.UnitPrices*OD.Quatity) AS Total_Sales
--FROM Customers AS C INNER JOIN Orders AS O
--ON C.CustomerID=O.CustomerID INNER JOIN OrderDetails AS OD
--ON OD.OrderID=O.OrderID INNER JOIN Products AS P
--ON P.ProductID=OD.ProductID INNER JOIN SalesPersons AS SP
--ON SP.SalesPersonID=O.SalesPersonID
--WHERE Total_Sales;

SELECT 
    O.OrderID,
    SUM(P.UnitPrices * OD.Quatity) AS TotalSales
FROM Orders O
JOIN OrderDetails OD ON O.OrderID = OD.OrderID
JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY O.OrderID
HAVING SUM(P.UnitPrices * OD.Quatity) =
(
    SELECT SUM(P2.UnitPrices * OD2.Quatity)
    FROM Orders O2
    JOIN OrderDetails OD2 ON O2.OrderID = OD2.OrderID
    JOIN Products P2 ON P2.ProductID = OD2.ProductID
    GROUP BY O2.OrderID
    ORDER BY SUM(P2.UnitPrices * OD2.Quatity) DESC
    OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY
);

--Question 3 Goup By & Having

SELECT 
    SP.SalesPersonName,
    SUM(P.UnitPrices * OD.Quatity) AS TotalSales
FROM SalesPersons SP
INNER JOIN Orders O 
    ON SP.SalesPersonID = O.SalesPersonID
INNER JOIN OrderDetails OD 
    ON O.OrderID = OD.OrderID
INNER JOIN Products P 
    ON P.ProductID = OD.ProductID
GROUP BY SP.SalesPersonName
HAVING SUM(P.UnitPrices * OD.Quatity) > 60000;



--Question 4 Subquery Usage

SELECT 
    C.CustomerName,
    SUM(P.UnitPrices * OD.Quatity) AS TotalSpent
FROM Customers C
INNER JOIN Orders O 
    ON C.CustomerID = O.CustomerID
INNER JOIN OrderDetails OD 
    ON O.OrderID = OD.OrderID
INNER JOIN Products P 
    ON P.ProductID = OD.ProductID
GROUP BY C.CustomerName
HAVING SUM(P.UnitPrices * OD.Quatity) >
(
    SELECT AVG(CustomerTotal)
    FROM (
        SELECT 
            SUM(P2.UnitPrices * OD2.Quatity) AS CustomerTotal
        FROM Customers C2
        INNER JOIN Orders O2 ON C2.CustomerID = O2.CustomerID
        INNER JOIN OrderDetails OD2 ON O2.OrderID = OD2.OrderID
        INNER JOIN Products P2 ON P2.ProductID = OD2.ProductID
        GROUP BY C2.CustomerID
    ) AS AvgTable
);

--Question 5 String and Date Functions 
SELECT 
    UPPER(CustomerName) AS CustomerName,
    DATENAME(MONTH, CAST(OrderDate AS DATE)) AS OrderMonth,
    CAST(OrderDate AS DATE) AS OrderDate
FROM Sales_Raw
WHERE YEAR(CAST(OrderDate AS DATE)) = 2026
  AND MONTH(CAST(OrderDate AS DATE)) = 1;
