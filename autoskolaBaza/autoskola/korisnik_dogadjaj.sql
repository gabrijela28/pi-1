CREATE TABLE [dbo].[korisnik_dogadjaj]
(
	[ID_dogadjaj] INT NOT NULL , 
    [ID_korisnik] INT NOT NULL, 
    [dolazak] BIT NOT NULL DEFAULT false,
	foreign key ([ID_dogadjaj]) references [dbo].[dogadjaj] (ID_dogadjaj),
	foreign key ([ID_korisnik]) references [dbo].[korisnik] (ID_korisnik)
)
