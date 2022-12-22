CREATE TABLE [dbo].[Commande]
(
	[Id] BIGINT NOT NULL IDENTITY, 
    [Date] DATE NOT NULL 
        CONSTRAINT DF_Commande_Date DEFAULT (GETDATE()), 
    CONSTRAINT [PK_Commande] PRIMARY KEY ([Id]) 
)
