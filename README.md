# TestTask

```sql

IF OBJECT_ID('[dbo].[ProductCategory]', 'U') IS NOT NULL
DROP TABLE [dbo].[ProductCategory]
GO

IF OBJECT_ID('[dbo].[Categories]', 'U') IS NOT NULL
DROP TABLE [dbo].[Categories]
GO

IF OBJECT_ID('[dbo].[Products]', 'U') IS NOT NULL
DROP TABLE [dbo].[Products]
GO


CREATE TABLE [Products] (
  [Id] int PRIMARY KEY,
  [Name] varchar(255)
);

CREATE TABLE [Categories] (
  [Id] int PRIMARY KEY,
  [Name] varchar(255)
);
GO


CREATE TABLE [ProductCategory] (
  [ProductID] int,
  CategoryID int,
  CONSTRAINT PK_ProductId_CategoryId PRIMARY KEY ([ProductID], [CategoryID]),
  CONSTRAINT FK_Products_Id FOREIGN KEY ([ProductID]) REFERENCES [Products]([Id]), 
  CONSTRAINT FK_Catories_Id FOREIGN KEY ([CategoryID]) REFERENCES [Categories]([Id])
);
GO


INSERT INTO [Products] ([Id], [Name])
VALUES (1, 'Product 1'),
       (2, 'Product 2'),
       (3, 'Product 3'),
       (4, 'Product 4');

INSERT INTO [Categories] ([Id], [Name])
VALUES (1, 'Category A'),
       (2, 'Category B'),
       (3, 'Category C');

INSERT INTO [ProductCategory] ([ProductID], [CategoryID])
VALUES (1, 1),
       (1, 2),
       (2, 2),
       (3, 1),
       (3, 3);

GO
SELECT [Products].[Name] AS [Product], [Categories].[Name] AS [Category]
FROM [Products]
LEFT JOIN [ProductCategory] ON [Products].[Id] = [ProductCategory].[ProductID]
LEFT JOIN [Categories] ON [ProductCategory].[CategoryID] = [Categories].[Id]
```
