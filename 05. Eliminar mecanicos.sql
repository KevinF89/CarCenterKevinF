Use PruebaKevinForero
GO
-- =============================================
-- Author:		Kevin forero
-- Create date: 01-11-2021
-- Description:	Deletes a registry from Mecanicos table by document and document type
-- =============================================
CREATE PROCEDURE [dbo].[SP_DELELETE_MECANICO] 
	@TipoDocumento Varchar(2) ,
	@Documento int 
	
AS
BEGIN
	SET NOCOUNT ON;
		DELETE	FROM dbo.Mecanicos 
		WHERE	Tipo_Documento = @TipoDocumento 
		AND		Documento =  @Documento
END
