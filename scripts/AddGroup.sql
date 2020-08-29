create proc AddGroup
	@pid tinyint,
	@adid tinyint,
	@gsid tinyint,
	@cid tinyint,
	@comp_date date,
	@lid int
as
	insert into groups (pid, adid, gsid, cid, comp_date, lid)
	values (@pid, @adid, @gsid, @cid, @comp_date, @lid)