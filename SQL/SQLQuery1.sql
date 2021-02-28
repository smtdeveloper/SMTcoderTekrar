-- Select secer
-- Alnans tablo ismini değistirir.
SELECT ContactName isim, City sehir   FROM Customers

-- where kosul 
select * from Customers where city = 'Berlin'

-- BÜYÜK kücük duyarsız dır  
--or yada, ikisinide getir anlamında
Select * from Products where CategoryID = 1 or CategoryID = 3

-- and ve,  CategoryID 1 olanları ve  UnitPrice 10' den büyük olanlar
Select * from Products where CategoryID = 1 and UnitPrice  > 10

-- order = sıralama, ProductName göre sıralar
select * from Products order by ProductName

-- order = sıralama, CategoryID göre sıralar, CategoryID İCİNDE'DE ProductName SIRALAR   
select * from Products order by  CategoryID,ProductName

-- asc Artan
SELECT * FROM Products ORDER BY UnitPrice asc -- ascending ( Artan)  default (Varsayılan) olarak gelir 

-- desc Düşen
SELECT * FROM Products ORDER BY UnitPrice desc -- desending ( Düşen) 

-- CategoryID'si 1 olanları getir ve UnitPrice' se göre sırala düsen
SELECT * FROM Products where CategoryID = 1 ORDER BY UnitPrice desc

-- count = adet, kaç  Customers  var.
select count(*) from Customers

-- Products tablosundan CategoryID'si 3 olanları sayar 
select count(*) from Products where CategoryID = 3

--  group by tabloları Kendi icinde  gruplar, count ise kac adet oldugunu getirir.
select CategoryID, count(*) Adetleri  from Products  group by CategoryID

-- group by'de sıralama işlemleri yaparken Having kullanılır.
-- Products TABLOSUNDAN CategoryID'Sİ  10'dan kücük olanları GETİR.
select CategoryID, count(*) Adetleri  from Products  group by CategoryID Having  COUNT(*) < 10 

-- 
select CategoryID, count(*) Adetleri  from Products where UnitPrice > 20  group by CategoryID Having  COUNT(*) < 10 

-- -Joinlerr

-- inner join 2 tabloyu birlestirir 
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
ON Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

-- DTO Data  Transformation Object

select * from Products p inner  join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

-- inner join
Select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

-- left join =  Solda olup Sağda olmayanlarıda getir
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- ÖDEV : Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
select  p.ProductID AS ürünId , p.ProductName as UrunAdi , 
sum(od.UnitPrice * od.Quantity) as KazanilanMiktar 
from Products as p inner join [Order Details] as od
on p.ProductID = od.ProductID
group by p.ProductName, p.ProductID,  p.UnitPrice
order by p.UnitPrice desc

