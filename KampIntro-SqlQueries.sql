-- Product tablosunda hangi kategoride kaç ürün var listele ?
Select CategoryID, count(*) From Products Group By CategoryID

--Ürün sayısı 10'dan az olan kategorileri listele
Select CategoryID From Products Group By CategoryId  having count(*) < 10

--Ürün sayısı 10'dan az olan ve Fiyatı 20'den büyük olan kategorileri listele
Select CategoryID From Products where UnitPrice < 20 Group By CategoryId  having count(*) < 10

Select ProductID, ProductName, UnitPrice, CategoryName From Products 
Inner Join Categories On Products.CategoryID = Categories.CategoryID
Where Products.UnitPrice > 10

-- Solda(Products) olup sağda(Order Details) olmayanlarıda listeler 
Select * From Products p
Left Join [Order Details] od On p.ProductID = od.ProductID

-- 3 Tablo birleştirme
Select * From Products p
Left Join [Order Details] od On p.ProductID = od.ProductID
Inner Join Orders o On Orders.OrderID = od.OrderID 

-- Sisteme kayıt olmuş ama sipariş oluşturmamış müşterileri listele
Select * From Customers c 
Left Join Orders o On c.CustomerID = o.CustomerID
Where o.CustomerID is Null