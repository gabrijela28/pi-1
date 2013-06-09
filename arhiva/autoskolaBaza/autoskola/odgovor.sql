CREATE TABLE [dbo].[odgovor]
(

	[ID_odgovor] INT NOT NULL primary key, 
    [ID_pitanja] INT NOT NULL, 
    [tekst] VARCHAR(50) NOT NULL, 
    [tocno] BIT NOT NULL, 
    [srcOdgovor] VARCHAR(50) NULL,
	foreign key ([ID_pitanja]) references [dbo].[pitanja] (ID_pitanja)
)
