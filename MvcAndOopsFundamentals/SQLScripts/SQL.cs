1.select * from customers where name like '%Joe'

------------------------ -

2.
Select Product.Name from
	OrderProduct join Order join Product
	on OrderProduct.OrderId = Order.OrderId
	and OrderProduct.ProductId = Order.ProductId
	and Order.CustomerId = Customer.CustomerId

where
	Customer.Name = "Joe"
	and CreatedAt > '11/1/2016'


	