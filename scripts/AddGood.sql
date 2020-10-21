create proc AddGood
	@ordid bigint,
	@rec_date date
as
	insert into stock (ordid, rec_date)
	values (@ordid, @rec_date)