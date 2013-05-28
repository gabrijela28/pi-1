CREATE TABLE [dbo].[dogadjaj]
(
	[ID_dogadjaj] INT NOT NULL PRIMARY KEY, 
    [kreirao] INT NOT NULL, 
    [napomena] VARCHAR(300) NOT NULL, 
    [datum] TIMESTAMP NOT NULL,
	FOREIGN KEY ([kreirao]) references [dbo].[korisnik]([ID_korisnik])
)
