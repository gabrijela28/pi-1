CREATE TABLE [dbo].[materijal]
(
	[ID_materijal] INT NOT NULL PRIMARY KEY, 
    [ID_cjelina] INT NOT NULL, 
    [opis] VARCHAR(150) NULL, 
    [srcMaterijal] VARCHAR(50) NULL,
	foreign key ([ID_cjelina]) references [dbo].[cjelina] (ID_cjelina)
)
