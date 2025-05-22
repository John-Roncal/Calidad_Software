CREATE DATABASE NorRevistaBD
GO
USE NorRevistaBD
GO

-- Tabla para categorías
CREATE TABLE Categoria (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
	Estado BIT DEFAULT 1
)
GO

-- Tabla para provincias
CREATE TABLE Provincia (
    Codigo CHAR(3) PRIMARY KEY,  -- Usamos código de provincia
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
	Estado BIT DEFAULT 1
)
GO

-- Tabla principal de clientes
CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(60) NOT NULL,
    Mail NVARCHAR(50) NOT NULL UNIQUE,
    Web NVARCHAR(40) NULL,
	Condicion NVARCHAR(20) DEFAULT 'Nuevo',
    ProvinciaId CHAR(3) NOT NULL FOREIGN KEY REFERENCES Provincia(Codigo),
    CategoriaId INT NOT NULL FOREIGN KEY REFERENCES Categoria(Id),
    Estado BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE()
)
GO

-- Crear la tabla Rol 
CREATE TABLE [Rol]
(
    [RolID] INT NOT NULL IDENTITY (1, 1),
    [NombreRol] NVARCHAR(50) NOT NULL,
    [EstadoRol] BIT NOT NULL,
    CONSTRAINT PK_Rol PRIMARY KEY (RolID)
);
GO

-- Insertar roles iniciales: Admin y Usuario
INSERT INTO [Rol] ([NombreRol], [EstadoRol]) VALUES
('Admin', 1),
('Usuario', 1);
GO

-- Crear la tabla Usuario con contraseña como hash (varbinary)
CREATE TABLE [Usuario]
(
    [UsuarioID] INT NOT NULL IDENTITY (1, 1),
    [RolID] INT NOT NULL,
    [Usuario] NVARCHAR(50) NOT NULL,
    [Clave] VARBINARY(64) NOT NULL,  -- Contraseña encriptada con SHA-256
    [EstadoUsuario] BIT NOT NULL,
    CONSTRAINT PK_Usuario PRIMARY KEY (UsuarioID),
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY ([RolID]) REFERENCES [Rol]([RolID])
);
GO

CREATE OR ALTER PROCEDURE spValidarCredenciales
    @Nombre NVARCHAR(50),
    @Contraseña VARBINARY(64)
AS
BEGIN
    SELECT COUNT(*) 
    FROM Usuario 
    WHERE Usuario = @Nombre AND Clave = @Contraseña AND EstadoUsuario = 1;
END
GO

CREATE OR ALTER PROCEDURE spObtenerUsuarioPorNombre
    @Nombre nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        UsuarioID, 
        RolID, -- Corregido de TipoUsuarioID a RolID
        Usuario, 
        Clave, 
        EstadoUsuario -- Corregido de estUsuario a EstadoUsuario
    FROM Usuario
    WHERE Usuario = @Nombre;
END
GO

INSERT INTO Usuario (RolID, Usuario, Clave, EstadoUsuario)
VALUES (
    1, -- ID del rol "Admin"
    'admin123',
    HASHBYTES('SHA2_256', CONVERT(VARBINARY(100), '123')), -- contraseña real
    1
);
GO

INSERT INTO Usuario (RolID, Usuario, Clave, EstadoUsuario)
VALUES (
    1, -- ID del rol "Admin"
    'admin',
    HASHBYTES('SHA2_256', CONVERT(VARBINARY(100), '123')), -- contraseña real
    1
);
GO

INSERT INTO Usuario (RolID, Usuario, Clave, EstadoUsuario)
VALUES (
    2, -- ID del rol "Admin"
    'user',
    HASHBYTES('SHA2_256', CONVERT(VARBINARY(100), '123')), -- contraseña real
    1
);
GO

CREATE OR ALTER PROCEDURE spObtenerRolIDPorNombre
    @Nombre NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT RolID
    FROM Usuario
    WHERE Usuario = @Nombre;
END
GO

-- Tabla para seguimiento de contactos (registra toda interacción)
CREATE TABLE ContactoCliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL FOREIGN KEY REFERENCES Cliente(Id),
    FechaContacto DATETIME DEFAULT GETDATE(),
    Propuesta NVARCHAR(MAX) NULL,
    Respondido BIT DEFAULT 0,  -- 0 = No respondió, 1 = Respondió
    FechaRespuesta DATETIME NULL,
    RequiereRecordatorio BIT DEFAULT 0,
    FechaRecordatorio DATETIME NULL,
    Comentarios NVARCHAR(MAX) NULL
)
GO

-- Índices para mejorar rendimiento
CREATE INDEX IX_Clientes_Email ON Cliente(Mail)
GO
CREATE INDEX IX_Contactos_Cliente ON ContactoCliente(ClienteId)
GO

--		STORED PROCEDURE		--

-- Categoria
--CREATE
CREATE PROCEDURE spInsetarCategoria
    @Nombre NVARCHAR(50),
    @NuevoId INT OUTPUT
AS
BEGIN
    BEGIN TRY
        INSERT INTO Categoria (Nombre)
        VALUES (@Nombre)
        
        SET @NuevoId = SCOPE_IDENTITY()
        SELECT 1 AS Resultado, 'Categoria creada exitosamente' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO
--READ
CREATE PROCEDURE spListarCategoria
AS
BEGIN
    SELECT * FROM Categoria WHERE Estado = 1 ORDER BY Nombre
END
GO
--UPDATE
CREATE PROCEDURE spActualizarCategoria
    @Id INT,
    @Nombre NVARCHAR(50)
AS
BEGIN
    BEGIN TRY
        UPDATE Categoria SET
            Nombre = @Nombre
        WHERE Id = @Id
        
        IF @@ROWCOUNT > 0
            SELECT 1 AS Resultado, 'Categoria actualizada exitosamente' AS Mensaje
        ELSE
            SELECT 0 AS Resultado, 'Categoria no encontrada' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO
--DELETE
CREATE PROCEDURE spDeshabilitarCategoria
    @Id INT
AS
BEGIN
    UPDATE Categoria SET Estado = 0 WHERE Id = @Id
    SELECT 1 AS Resultado, 'Categoria marcada como inactiva' AS Mensaje
END
GO
--CONDICION
CREATE PROCEDURE spExisteNombreCategoria
    @Nombre NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Categoria WHERE Nombre = @Nombre AND Estado = 1
END
GO
-- Pronvincia
--CREATE
CREATE OR ALTER PROCEDURE spInsetarProvincia
	@Id CHAR(3),
    @Nombre NVARCHAR(50)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Provincia (Codigo, Nombre)
        VALUES (@Id, @Nombre)
        
        SELECT 1 AS Resultado, 'Provincia creada exitosamente' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO
--READ
CREATE PROCEDURE spListarProvincia
AS
BEGIN
    SELECT * FROM Provincia WHERE Estado = 1 ORDER BY Nombre
END
GO
--UPDATE
CREATE PROCEDURE spActualizarProvincia
    @Id CHAR(3),
    @Nombre NVARCHAR(50)
AS
BEGIN
    BEGIN TRY
        UPDATE Provincia SET
            Nombre = @Nombre
        WHERE Codigo = @Id
        
        IF @@ROWCOUNT > 0
            SELECT 1 AS Resultado, 'Provincia actualizada exitosamente' AS Mensaje
        ELSE
            SELECT 0 AS Resultado, 'Provincia no encontrada' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO
--DELETE
CREATE PROCEDURE spDeshabilitarProvincia
    @Id CHAR(3)
AS
BEGIN
    UPDATE Provincia SET Estado = 0 WHERE Codigo = @Id
    SELECT 1 AS Resultado, 'Provincia marcada como inactiva' AS Mensaje
END
GO

-- Cliente
--CREATE
CREATE PROCEDURE spInsetarCliente
    @Nombre NVARCHAR(60),
    @Mail NVARCHAR(50),
    @Web NVARCHAR(40) = NULL,
    @ProvinciaId CHAR(3),
    @CategoriaId INT,
    @NuevoId INT OUTPUT
AS
BEGIN
    BEGIN TRY
        INSERT INTO Cliente (Nombre, Mail, Web, ProvinciaId, CategoriaId)
        VALUES (@Nombre, @Mail, @Web, @ProvinciaId, @CategoriaId)
        
        SET @NuevoId = SCOPE_IDENTITY()
        SELECT 1 AS Resultado, 'Cliente creado exitosamente' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO
--READ
CREATE OR ALTER PROCEDURE spListarCliente
AS
BEGIN
    SELECT 
        cl.Id AS ClienteId,
        cl.Nombre AS ClienteNombre,
        cl.Mail,
        cl.Web,
        ca.Id AS CategoriaId,
        ca.Nombre AS CategoriaNombre,
        pr.Codigo AS ProvinciaCodigo,
        pr.Nombre AS ProvinciaNombre,
        cl.Estado,
        cl.FechaCreacion
    FROM Cliente cl 
    INNER JOIN Categoria ca ON cl.CategoriaId = ca.Id 
    INNER JOIN Provincia pr ON cl.ProvinciaId = pr.Codigo 
    WHERE cl.Estado = 1
    ORDER BY cl.Nombre
END
GO
--UPDATE
CREATE PROCEDURE spActualizarCliente
    @Id INT,
    @Nombre NVARCHAR(255),
    @Web NVARCHAR(500) = NULL,
    @ProvinciaId CHAR(3),
    @CategoriaId INT
AS
BEGIN
    BEGIN TRY
        UPDATE Cliente SET
            Nombre = @Nombre,
            Web = @Web,
            ProvinciaId = @ProvinciaId,
            CategoriaId = @CategoriaId
        WHERE Id = @Id
        
        IF @@ROWCOUNT > 0
            SELECT 1 AS Resultado, 'Cliente actualizado exitosamente' AS Mensaje
        ELSE
            SELECT 0 AS Resultado, 'Cliente no encontrado' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO
--DELETE
CREATE PROCEDURE spDeshabilitarCliente
    @Id INT
AS
BEGIN
    UPDATE Cliente SET Estado = 0 WHERE Id = @Id
    SELECT 1 AS Resultado, 'Cliente marcado como inactivo' AS Mensaje
END
GO
--BUSCAR
CREATE PROCEDURE spBuscarCliente
	@Nombre NVARCHAR(50)
AS
BEGIN
	SELECT Id FROM Cliente WHERE Nombre = @Nombre
END
GO

--ContactoCliente
--CREATE
CREATE PROCEDURE spInsetarContacto
    @ClienteId INT,
    @Propuesta NVARCHAR(MAX),
	@Comentarios NVARCHAR(MAX)
AS
BEGIN
    BEGIN TRY
        INSERT INTO ContactoCliente(ClienteId, Propuesta, Comentarios)
        VALUES (@ClienteId, @Propuesta, @Comentarios)

        SELECT 1 AS Resultado, 'Contacto registrado exitosamente' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO

-- Procedimientos para gestión de contactos
CREATE PROCEDURE usp_AddContacto
    @ClienteId INT,
    @Propuesta NVARCHAR(MAX) = NULL
AS
BEGIN
    BEGIN TRY
        INSERT INTO ContactoCliente (ClienteId, Propuesta)
        VALUES (@ClienteId, @Propuesta)
        
        SELECT 1 AS Resultado, 'Contacto registrado exitosamente' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO

CREATE PROCEDURE usp_ResponderContacto
    @ContactoId INT,
    @Respondido BIT,
    @Comentarios NVARCHAR(MAX) = NULL
AS
BEGIN
    BEGIN TRY
        UPDATE ContactoCliente SET
            Respondido = @Respondido,
            FechaRespuesta = GETDATE(),
            Comentarios = @Comentarios
        WHERE Id = @ContactoId
        
        SELECT 1 AS Resultado, 'Respuesta registrada' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO

CREATE PROCEDURE usp_ProgramarRecordatorio
    @ContactoId INT,
    @DiasRecordatorio INT = 7
AS
BEGIN
    BEGIN TRY
        UPDATE ContactoCliente SET
            RequiereRecordatorio = 1,
            FechaRecordatorio = DATEADD(DAY, @DiasRecordatorio, GETDATE())
        WHERE Id = @ContactoId
        
        SELECT 1 AS Resultado, 'Recordatorio programado' AS Mensaje
    END TRY
    BEGIN CATCH
        SELECT 0 AS Resultado, ERROR_MESSAGE() AS Mensaje
    END CATCH
END
GO

-- Procedimientos de reportes
CREATE PROCEDURE usp_GetClientesSinRespuesta
    @DiasDesdeContacto INT = 7
AS
BEGIN
    SELECT 
        c.Id,
        c.Nombre,
        c.Mail,
        MAX(cc.FechaContacto) AS UltimoContacto
    FROM Cliente c
    JOIN ContactosClientes cc ON c.Id = cc.ClienteId
    WHERE cc.Respondido = 0
    AND cc.FechaContacto < DATEADD(DAY, -@DiasDesdeContacto, GETDATE())
    AND c.Estado = 1
    GROUP BY c.Id, c.Nombre, c.Mail
END
GO

CREATE PROCEDURE usp_GetProximosRecordatorios
    @DiasProximos INT = 3
AS
BEGIN
    SELECT 
        c.Nombre,
        c.Mail,
        cc.FechaRecordatorio,
        DATEDIFF(DAY, GETDATE(), cc.FechaRecordatorio) AS DiasRestantes
    FROM ContactoCliente cc
    JOIN Cliente c ON cc.ClienteId = c.Id
    WHERE cc.RequiereRecordatorio = 1
    AND cc.Respondido = 0
    AND cc.FechaRecordatorio BETWEEN GETDATE() AND DATEADD(DAY, @DiasProximos, GETDATE())
END
GO

-- Procedimiento de búsqueda avanzada
CREATE PROCEDURE usp_SearchCliente
    @SearchTerm NVARCHAR(255) = NULL,
    @CategoriaId INT = NULL,
    @ProvinciaId CHAR(3) = NULL,
    @ConWeb BIT = NULL
AS
BEGIN
    SELECT 
        c.Id,
        c.Nombre,
        c.Mail,
        c.Web,
        p.Nombre AS Provincia,
        cat.Nombre AS Categoria
    FROM Cliente c
    JOIN Provincia p ON c.ProvinciaId = p.Codigo
    JOIN Categoria cat ON c.CategoriaId = cat.Id
    WHERE 
        (@SearchTerm IS NULL OR 
         c.Nombre LIKE '%' + @SearchTerm + '%' OR
         c.Mail LIKE '%' + @SearchTerm + '%')
        AND (@CategoriaId IS NULL OR c.CategoriaId = @CategoriaId)
        AND (@ProvinciaId IS NULL OR c.ProvinciaId = @ProvinciaId)
        AND (@ConWeb IS NULL OR (c.Web IS NOT NULL AND @ConWeb = 1))
    ORDER BY c.Nombre
END
GO

CREATE or alter PROCEDURE [dbo].[spCargarCategoria]
as
select Id, Nombre from Categoria where Estado = 1
GO

CREATE or alter PROCEDURE [dbo].[spCargarProvincia]
as
select Codigo,Nombre from Provincia where Estado = 1
GO