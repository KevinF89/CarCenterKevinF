--- Creación base de datos
CREATE DATABASE PruebaKevinForero
USE PruebaKevinForero

---------- Clientes

CREATE TABLE [dbo].[Tipos_Documento](
	Codigo Varchar(2) NOT NULL,
	Nombre varchar(20) NOT NULL,
	Abreviatura varchar(5),

 CONSTRAINT [PK_Tipos_Documento] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE dbo.Clientes(
	Tipo_Documento Varchar(2) NOT NULL,
	Documento		Int NOT NULL,
	Primer_Nombre Varchar(30),
	Segundo_Nombre Varchar(30),
	Primer_Apellido Varchar(30),
	Segundo_Apellido Varchar(30),
	Celular			Varchar(10),
	Direccion		Varchar(200),
	Email			Varchar(100),
	CONSTRAINT [FK_Tipos_Documento_Cliente] FOREIGN KEY (Tipo_Documento) REFERENCES Tipos_Documento (Codigo),

	
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	Tipo_Documento ASC, Documento Asc
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Estados_Mecanicos](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Estado] varchar(20) NOT NULL,

 CONSTRAINT [PK_Estados_Mecanicos] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

---------- Mecanicos
CREATE TABLE dbo.Mecanicos(
	Tipo_Documento Varchar(2) NOT NULL,
	Documento		Int NOT NULL,
	Primer_Nombre Varchar(30),
	Segundo_Nombre Varchar(30),
	Primer_Apellido Varchar(30),
	Segundo_Apellido Varchar(30),
	Celular			Varchar(10),
	Direccion		Varchar(200),
	Email			Varchar(100),
	Estado			int,
	CONSTRAINT [FK_Estados_Mecanicos_Mecanico] FOREIGN KEY (Estado) REFERENCES Estados_Mecanicos (Codigo),
	CONSTRAINT [FK_Tipos_Documento_Mecanico] FOREIGN KEY (Tipo_Documento) REFERENCES Tipos_Documento (Codigo),

 CONSTRAINT [PK_Mecanicos] PRIMARY KEY CLUSTERED 
(
	Tipo_Documento ASC, Documento Asc
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]




----------	Marcas
CREATE TABLE dbo.Marcas(
	Codigo	Int IDENTITY(1,1) NOT NULL,
	Nombre_Marca Varchar(30)	,

 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]




---------- Vehiculos
CREATE TABLE dbo.Vehiculos(
	Placa	Varchar(6),
	Color	Varchar(30),
	Cod_Marca	int,
	Cli_Documento int ,
	Cli_Tipo_Documento	Varchar(2) ,
	CONSTRAINT [FK_Vehiculos_Marcas] FOREIGN KEY (Cod_Marca) REFERENCES Marcas (Codigo),
	CONSTRAINT [FK_Vehiculos_Clientes] FOREIGN KEY (Cli_Tipo_Documento, Cli_Documento) REFERENCES Clientes (Tipo_Documento, Documento),
	CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
	(
		Placa ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]


	
----------	Servicios
CREATE TABLE dbo.Servicios(
	Codigo	int IDENTITY(1,1) NOT NULL,
	Nombre_Servicio Varchar(100),
	Precio	numeric,
	

 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Estados_Mantenimiento](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Estado] varchar(20) NOT NULL,

 CONSTRAINT [PK_Estados_Mantenimiento] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


----------	 Mantenimiento
CREATE TABLE dbo.Mantenimientos(
	Codigo	int IDENTITY(1,1) NOT NULL,
	Cod_Placa Varchar(6),
	Fecha	Datetime,
	Mec_Tipo_Documento Varchar(2),
	Mec_Documento  int,
	Estado	int,
	CONSTRAINT [FK_Mantenimiento_Placa] FOREIGN KEY (Cod_Placa) REFERENCES Vehiculos (Placa),
	CONSTRAINT [FK_Mantenimiento_Mecanicos] FOREIGN KEY (Mec_Tipo_Documento, Mec_Documento) REFERENCES Mecanicos (Tipo_Documento, Documento),
	CONSTRAINT [FK_Mantenimiento_Estados] FOREIGN KEY (Estado) REFERENCES Estados_Mantenimiento (Codigo),

 CONSTRAINT [PK_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


	
----------	Servicios por Mantenimiento
CREATE TABLE dbo.Servicios_X_Mantenimientos(
	Codigo int IDENTITY(1,1) NOT NULL,
	Tiempo_Estimado int,
	Cod_Servicio int,
	Cod_Mantenimiento int,
	CONSTRAINT [FK_Servicios_Mtto_Ser] FOREIGN KEY (Cod_Servicio) REFERENCES Servicios (Codigo),
	CONSTRAINT [FK_Servicios_Mtto_Mtto] FOREIGN KEY (Cod_Mantenimiento) REFERENCES Mantenimientos (Codigo),

 CONSTRAINT [PK_Servicios_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]






----------	Fotos / Imagenes
CREATE TABLE dbo.Fotos(
	Codigo int IDENTITY(1,1) NOT NULL,
	Ruta Varchar(200),
	Cod_Mantenimiento int
	CONSTRAINT [FK_Imagenes_Mantenimiento] FOREIGN KEY (Cod_Mantenimiento) REFERENCES Mantenimientos (Codigo),
	

 CONSTRAINT [PK_Imagenes] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



----------	Repuestos
CREATE TABLE dbo.Repuestos(
	Codigo int IDENTITY(1,1) NOT NULL,
	Nombre_Repuesto Varchar(100),
	Precio_Unitario	numeric,
	Unidades_Inventario int,
	Proveedor Varchar(200),
	
 CONSTRAINT [PK_Repuestos] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


----------	Repuestos por Mantenimiento
CREATE TABLE dbo.Repuestos_X_Mantenimientos(
	Codigo int IDENTITY(1,1) NOT NULL,
	Unidades int,
	Tiempo_Estimado int,
	Cod_Repuesto int,
	Cod_Mantenimiento int,
	CONSTRAINT [FK_Repuestos_Mtto_Repuesto] FOREIGN KEY (Cod_Repuesto) REFERENCES Repuestos (Codigo),
	CONSTRAINT [FK_Repuestos_Mtto_Mtto] FOREIGN KEY (Cod_Mantenimiento) REFERENCES Mantenimientos (Codigo),

 CONSTRAINT [PK_Repuesto_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Presupuesto_X_Mantenimiento](
	Codigo int IDENTITY(1,1) NOT NULL,
	Cod_Placa varchar(6) NOT NULL,
	Cod_Mantenimiento int NOT NULL,
	Presupuesto numeric NOT NULL,

	CONSTRAINT [FK_Presupuesto_X_Mantenimiento_Vehiculos] FOREIGN KEY([Cod_Placa]) REFERENCES [dbo].[Vehiculos] (Placa),
	CONSTRAINT [FK_Presupuesto_X_Mantenimiento_Mantenimientos] FOREIGN KEY(Cod_Mantenimiento) REFERENCES Mantenimientos (Codigo),

 CONSTRAINT [PK_Presupuesto_X_Mantenimiento] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


----------	Facturacion
CREATE TABLE dbo.Facturas(
	Codigo int IDENTITY(1,1) NOT NULL,
	Valor_Total		numeric,
	Iva				numeric,
	Cod_Mantenimiento int,
	Cli_Tipo_Documento varchar(2),
	Cli_Documento Int,
	CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY (Cli_Tipo_Documento,Cli_Documento) REFERENCES Clientes (Tipo_Documento, Documento),
	CONSTRAINT [FK_Facturas_Mantenimiento] FOREIGN KEY (Cod_Mantenimiento) REFERENCES Mantenimientos (Codigo),

 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	Codigo ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


----Data inicial
INSERT INTO Tipos_Documento (Codigo,Nombre,Abreviatura) VALUES ('CC','CÉDULA DE CIUDADANÍA','C.C.')
INSERT INTO Tipos_Documento (Codigo,Nombre,Abreviatura) VALUES ('CE','CÉDULA DE EXTRANJER','C.E.')

INSERT INTO Estados_Mecanicos (Nombre_Estado) VALUES ('DISPONIBLE')
INSERT INTO Estados_Mecanicos (Nombre_Estado) VALUES ('OCUPADO')

INSERT INTO Estados_Mantenimiento(Nombre_Estado) VALUES ('PENDIENTE')
INSERT INTO Estados_Mantenimiento (Nombre_Estado) VALUES ('FINALIZADO')