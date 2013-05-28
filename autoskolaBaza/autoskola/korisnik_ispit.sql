CREATE TABLE [dbo].[korisnik_ispit]
(
	[ID_korisnik_ispit] INT NOT NULL PRIMARY KEY,
	[ID_korisnik] INT NOT NULL, 
    [ID_ispit] INT NOT NULL, 
    foreign key ([ID_korisnik]) references [dbo].[korisnik] (ID_korisnik),
	foreign key ([ID_ispit]) references [dbo].[ispit] (ID_ispit)
)
