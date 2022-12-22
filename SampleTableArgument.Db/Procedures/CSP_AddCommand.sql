CREATE PROCEDURE [dbo].[CSP_AddCommand]
	@Details Detail READONLY
AS
BEGIN
	INSERT INTO Commande ([Date]) VALUES (DEFAULT)
	DECLARE @CommandeId BIGINT = SCOPE_IDENTITY(); 

	INSERT INTO Detail (CommandeId, ProduitId, Quantite) 
	SELECT @CommandeId, ProduitId, Quantite FROM @Details	
END
