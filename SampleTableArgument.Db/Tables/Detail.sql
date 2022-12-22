CREATE TABLE [dbo].[Detail]
(
	[CommandeId] BIGINT NOT NULL, 
	[ProduitId] BIGINT NOT NULL,
	[Quantite] INT NOT NULL,
    CONSTRAINT [PK_Detail] PRIMARY KEY ([CommandeId], [ProduitId]) 
)
