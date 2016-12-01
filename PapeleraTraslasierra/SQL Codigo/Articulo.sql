











create procedure InsertarArticulo
@Nombre varchar (50),
@Categoria varchar (50),
@PrecioUnitario money ,
@precioVenta money,
@Stock int,
@StockMin int,
@StockMax int,
@Descripcion varchar(100)
AS
begin
INSERT INTO Articulo (Nombre,Categoria,PrecioUnitario,PrecioVenta,Stock,StockMin,StockMax,Descripcion)values 
(@Nombre,@Categoria,@PrecioUnitario,@precioVenta,@Stock,@StockMin,@StockMax,@Descripcion)
select @@IDENTITY as idArticulo
end


create table Articulo
(
idArticulo int identity (1,1),
Nombre varchar (50),
Categoria varchar(50)
,PrecioUnitario money
,PrecioVenta money
,Stock int
,StockMin int
,StockMax int
,Descripcion varchar (50)
)