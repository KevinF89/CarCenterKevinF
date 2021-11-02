Use PruebaKevinForero
GO
-- =============================================
-- Author:		Kevin Forero
-- Create date: 01-11-2021
-- Description:	Insert a new registry in the Mecanicos table
-- =============================================

CREATE PROCEDURE [dbo].[SP_INSERT_MECANICO] 

	@TipoDocumento Varchar(2) ,
	@Documento int ,
	@PrimerNombre Varchar(30),
	@SegundoNombre Varchar(30) = null,
	@PrimerApellido Varchar(30),
	@SegundoApellido Varchar(30)= null,
	@Celular			Varchar(10),
	@Direccion		Varchar(200),
	@Email			Varchar(100)
AS
BEGIN
	SET NOCOUNT ON;

    IF NOT EXISTS(Select Top 1 1 from dbo.Mecanicos  Where Documento = @Documento and Tipo_Documento = @TipoDocumento)
	BEGIN
	     insert into dbo.Mecanicos 
		 (Tipo_Documento,	Documento,	Primer_Nombre,	Segundo_Nombre,	Primer_Apellido,	Segundo_Apellido,	Celular,	Direccion,	Email, Estado)
		 values
		 (@TipoDocumento ,@Documento ,@PrimerNombre ,@SegundoNombre ,@PrimerApellido ,@SegundoApellido,@Celular,@Direccion,@Email, 1)
	
     END
END
