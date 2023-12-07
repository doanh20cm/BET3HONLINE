SELECT
	u.UserName
   ,y.ProductName
   ,y.CategoryName
FROM Users AS u
FULL JOIN (SELECT
		p.ProductName
	   ,c.CategoryName
	   ,p.UserId
	FROM Products AS p
	FULL JOIN Categories AS c
		ON p.CategoryId = c.CategoryId) AS y
	ON u.UserId = y.UserId