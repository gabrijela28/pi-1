CREATE TABLE [dbo].[odgovor_ispit]
(	
	[ID_korisnik_ispit] INT NOT NULL,
    [ID_odgovor] int NOT NULL,
	foreign key ([ID_odgovor]) references [dbo].[odgovor] (ID_odgovor),
	foreign key ([ID_korisnik_ispit]) references [dbo].[korisnik_ispit] (ID_korisnik_ispit),
)
