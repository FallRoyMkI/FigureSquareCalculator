Ответ на третье задание:

SELECT P.ProductName, C.CategoryName
FROM Products AS P
Left JOIN ProductCategory AS PC ON P.ProductId = PC.ProductId
Left JOIN Categories AS C ON C.CategoryId = PC.CategoryId
