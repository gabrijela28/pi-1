CREATE TABLE [dbo].[korisnik_grupa]
(
	[ID_grupa] INT NOT NULL, 
    [ID_korisnik] INT NOT NULL ,
	foreign key ([ID_korisnik]) references [dbo].[korisnik] (ID_korisnik),
	foreign key ([ID_grupa]) references [dbo].[grupa] (ID_grupa)
)
