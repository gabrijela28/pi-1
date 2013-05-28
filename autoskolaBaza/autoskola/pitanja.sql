CREATE TABLE [dbo].[pitanja]
(
	[ID_pitanja] INT NOT NULL PRIMARY KEY, 
    [ID_cjelina] INT NOT NULL, 
    [tekst] VARCHAR(100) NOT NULL, 
    [srcPitanja] VARCHAR(50) NULL, 
    [bodovi] FLOAT NOT NULL,
	foreign key ([ID_cjelina]) references [dbo].[cjelina] (ID_cjelina)
)
