SELECT Products.Name, Category.Name
FROM Products 
LEFT JOIN Category ON Products.Id=Category.ProductId 
ORDER BY Products.name
