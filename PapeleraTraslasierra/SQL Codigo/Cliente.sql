Create procedure EliminarCliente
@idCliente INT

AS
BEGIN
	
	SET NOCOUNT ON;

  
    delete from Cliente where idCLiente= @idCliente

	end

Create procedure ModificarCliente
@idCleinte int,
@Nombre varchar (50),
@Direccion varchar (50),
@Localidad varchar (50),
@Email varchar (50),
@Telefono varchar (50)
AS
begin 
UPDATE Cliente
   SET Nombre = @Nombre
      ,Direccion = @Direccion
      ,Localidad = @Localidad
      ,Email= @Email
	  ,Telefono= @Telefono

 WHERE Cliente.idCLiente = @idCleinte

select * from Cliente where idCLiente = @idCleinte
end

CREATE PROCEDURE ObtenerTodos 
	
	
AS
BEGIN
	
	SET NOCOUNT ON;

   SELECT * FROM Clientes order by Clientes desc
	
END