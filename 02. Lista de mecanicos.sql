Use PruebaKevinForero
GO
-- =============================================
-- Author:		Kevin Forero
-- Create date: 01-11-2021
-- Description:	Gets a list of mechanics
-- =============================================
CREATE PROCEDURE [dbo].[SP_SELECT_MECANICO] 

AS
BEGIN
	SET NOCOUNT ON;

	SELECT  Tipo_Documento,Documento,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Celular,Direccion,Email,m.Estado, em.Nombre_Estado
	FROM dbo.Mecanicos m
	INNER JOIN Tipos_Documento td
	ON m.Tipo_Documento = td.Codigo
	INNER JOIN Estados_Mecanicos em
	ON m.Estado = em.Codigo

END
