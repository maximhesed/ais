create proc AddContractorMedia
	@name_first nvarchar(16),
	@name_last nvarchar(16),
	@patronymic nvarchar(16),
	@email nvarchar(64),
	@phone nvarchar(16),
	@price money,
	@timestamps nvarchar(238),
	@lid int
as 
	insert into contractors_media (name_first, name_last, patronymic, email, phone, price, timestamps, lid)
	values (@name_first, @name_last, @patronymic, @email, @phone, @price, @timestamps, @lid)