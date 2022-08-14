/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *
  FROM [Test].[dbo].[Product] as Product
  LEFT JOIN [Test].[dbo].[ProductCategory] as ProductCategory on ProductCategory.ProductId = Product.Id
  FULL OUTER JOIN [Test].[dbo].[Category] as Category on Category.Id = ProductCategory.CategoryId;