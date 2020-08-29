create proc AddContractorProduction
	@name_first nvarchar(16),
	@name_last nvarchar(16),
	@patronymic nvarchar(16),
	@email nvarchar(64),
	@phone nvarchar(16),
	@ordid bigint,
	@price money
as
	insert into contractors_production (name_first, name_last, patronymic, email, phone, ordid, price)
	values (@name_first, @name_last, @patronymic, @email, @phone, @ordid, @price)