create proc AddEmployee
	@name_first nvarchar(16),
	@name_last nvarchar(16),
	@patronymic nvarchar(16),
	@email nvarchar(64),
	@password_hash nvarchar(64),
	@phone nvarchar(16),
	@department nvarchar(32),
	@position nvarchar(32),
	@reg_date date
as
	insert into employees (name_first, name_last, patronymic, email, password_hash, phone, department, position, reg_date)
	values (@name_first, @name_last, @patronymic, @email, @password_hash, @phone, @department, @position, @reg_date)