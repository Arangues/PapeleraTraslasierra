

CREATE TABLE DetalleFactura(
	IdDetalles [int] IDENTITY(1,1) NOT NULL,
	IdEncabezadoFactura [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[Total] [decimal](10, 2) NULL,
	)


	CREATE TABLE EncambezadoFactura
	(
	IdEncabezadoFactura int identity (1,1),
	NumeroFactura int,
	Tipo varchar(50),
	Fecha date
	)