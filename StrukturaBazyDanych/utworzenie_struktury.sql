create table dbo.dokument_magazynowy (
	id_dokumentu_magazynowego int not null identity(1, 1) primary key,
	data datetime not null,
	numer_klienta int not null,
	nazwa varchar(100) not null,
	cena_netto decimal(8,2),
	cena_brutto decimal(8,2)
)
go

create table dbo.pozycja_dokumentu_magazynowego (
	id_pozycji_dokumentu_magazynowego int not null identity(1,1) primary key,
	nazwa_artykulu varchar(100) not null,
	liczba int not null,
	cena_netto decimal(8,2) not null,
	cena_brutto decimal(8,2) not null,
	id_dokumentu_magazynowego int not null,
	constraint FK_PozycjaDokumentuMagazynowego_DokumentMagazynowy foreign key (id_dokumentu_magazynowego)
        references dbo.dokument_magazynowy (id_dokumentu_magazynowego)
        on delete cascade
        on update cascade
)
go

create trigger dbo.tiud_aktualizacja_dokumentu_magazynowego on dbo.pozycja_dokumentu_magazynowego after insert, update, delete as
begin
	declare @id_dokumentu_magazynowego int
	
	select top 1 @id_dokumentu_magazynowego = id_dokumentu_magazynowego from inserted

	if ISNULL(@id_dokumentu_magazynowego, '') = ''
	begin
		select top 1 @id_dokumentu_magazynowego = id_dokumentu_magazynowego from deleted
	end

	update dm set
		cena_netto = pdm_g.cena_netto,
		cena_brutto = pdm_g.cena_brutto
	from dokument_magazynowy dm
	left join (
		select pdm.id_dokumentu_magazynowego, sum(pdm.cena_netto * pdm.liczba) as cena_netto, sum(pdm.cena_brutto * pdm.liczba) as cena_brutto 
		from pozycja_dokumentu_magazynowego pdm 
		group by pdm.id_dokumentu_magazynowego
	) pdm_g on dm.id_dokumentu_magazynowego = pdm_g.id_dokumentu_magazynowego
	where dm.id_dokumentu_magazynowego = @id_dokumentu_magazynowego
	
end 

