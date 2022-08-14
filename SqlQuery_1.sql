/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *
  FROM [Test].[dbo].[Product] as Product
  LEFT JOIN [Test].[dbo].[Category] as Category on Category.Id = Product.CategoryId