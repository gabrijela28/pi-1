CREATE TABLE [dbo].[grupa]
(
	[ID_grupa] INT NOT NULL PRIMARY KEY, 
    [ID_cjelina] INT NOT NULL, 
    [predavac] INT NOT NULL,
	FOREIGN KEY ([ID_cjelina]) references [dbo].[cjelina]([ID_cjelina])
)
