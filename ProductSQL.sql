	(
		select Products.ProductName, ProductTypes.ProductTypeName from ProductANDProductTypeTable 
		inner join Products
			on Products.ProductId = ProductANDProductTypeTable.ProductId
		inner join ProductTypes
			on ProductTypes.ProductTypeId = ProductANDProductTypeTable.ProductTypeId
	)
union 
	(
		select ProductName, '' from Products 
		where not exists 
			(
				select * from ProductANDProductTypeTable where ProductANDProductTypeTable.ProductId = Products.ProductId
			)
	)
;