CREATE TABLE [dbo].[korisnik]
(
	[ID_korisnik] INT NOT NULL , 
    [ime] VARCHAR(30) NOT NULL, 
    [prezime] VARCHAR(30) NOT NULL, 
    [korisnicko_ime] VARCHAR(30) NOT NULL, 
    [lozinka] VARCHAR(30) NOT NULL, 
    [oib] VARCHAR(30) NOT NULL, 
    [mail] VARCHAR(30) NULL, 
    [telefon] VARCHAR(30) NULL, 
    [ID_korisnikTip] INT NOT NULL, 
    CONSTRAINT [ID_korisnik] PRIMARY KEY ([ID_korisnik]),
	foreign key ([ID_korisnikTip]) references [dbo].[korisnikTip] (ID_korisnikTip)
)
