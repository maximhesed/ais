create proc AddLead
	@name_first nvarchar(16),
	@name_last nvarchar(16),
	@patronymic nvarchar(16),
	@email nvarchar(64),
	@phone nvarchar(16),
	@prom_time smallint,
	@appeal_date date
as 
	insert into leads (name_first, name_last, patronymic, email, phone, prom_time, appeal_date)
	values (@name_first, @name_last, @patronymic, @email, @phone, @prom_time, @appeal_date)