CREATE TABLE [dbo].[cjelina]
(
	[ID_cjelina] INT NOT NULL , 
    [ID_predmet] INT NOT NULL, 
    [naziv] VARCHAR(30) NOT NULL, 
    [opis] VARCHAR(200) NULL, 
    [bodovi] FLOAT NOT NULL DEFAULT 100, 
    PRIMARY KEY ([ID_cjelina]),
	FOREIGN KEY ([ID_predmet]) references [dbo].[predmet]([ID_predmet])
)
