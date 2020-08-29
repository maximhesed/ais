create proc AddOrdReq
	@prod_name nvarchar(64),
	@prod_quantity int,
	@period_date date,
	@pid tinyint,
	@lid int
as 
	insert into ord_reqs (prod_name, prod_quantity, period_date, pid, lid)
	values (@prod_name, @prod_quantity, @period_date, @pid, @lid)