CREATE TABLE [dbo].[ispit]
(
	[ID_ispit] INT NOT NULL PRIMARY KEY, 
    [ID_grupa] INT NOT NULL, 
    [datum] TIMESTAMP NOT NULL, 
    [napomena] VARCHAR(300) NULL, 
    [trajanje] TIME NULL,
	FOREIGN KEY ([ID_grupa]) references [dbo].[grupa]([ID_grupa])
)
