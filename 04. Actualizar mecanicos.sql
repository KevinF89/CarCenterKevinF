USE PruebaKevinForero
GO
-- =============================================
-- Author:		Kevin Forero
-- Create date: 01-11-2021
-- Description: Updates a registry in the Mecanicos table
-- =============================================
CREATE PROCEDURE [dbo].[SP_UPDATE_MECANICO] 
	@TipoDocumento Varchar(2) ,
	@Documento int ,
	@PrimerNombre Varchar(30),
	@SegundoNombre Varchar(30),
	@PrimerApellido Varchar(30),
	@SegundoApellido Varchar(30),
	@Celular			Varchar(10),
	@Direccion		Varchar(200),
	@Email			Varchar(100),
	@EstadoMecanico	int
AS
BEGIN
	SET NOCOUNT ON;
		UPDATE	dbo.Mecanicos 
		SET		Primer_Nombre	= @PrimerNombre,
				Segundo_Nombre	= @SegundoNombre,
				Primer_Apellido	= @PrimerApellido,
				Segundo_Apellido = @SegundoApellido,
				Celular			= @Celular,
				Direccion		= @Direccion,
				Email			= @Email,
				Estado = @EstadoMecanico
		WHERE	Tipo_Documento = @TipoDocumento
		AND		Documento =  @Documento     
END
