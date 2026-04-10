using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        // ============================================================
        //  CAMBIAR SOLO ESTA LÍNEA SEGÚN LA PC DONDE CORRES EL PROGRAMA
        // ============================================================
        private const string Server   = @"DESKTOP-0K66LOA\SQLEXPRESS";
        private const string Database = "museo2";

        private static string GetConnectionString()
            => $"Data Source={Server};Initial Catalog={Database};Integrated Security=True;Connect Timeout=30;";

        private static string GetMasterConnectionString()
            => $"Data Source={Server};Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";

        public static SqlConnection ObtenerConexion()
        {
            InicializarBaseDeDatos();
            return new SqlConnection(GetConnectionString());
        }

        private static bool _inicializado = false;

        private static void InicializarBaseDeDatos()
        {
            if (_inicializado) return;

            // PASO 1: Crear la base de datos si no existe
            using (var conn = new SqlConnection(GetMasterConnectionString()))
            {
                conn.Open();
                Exec(conn, $@"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{Database}')
                              CREATE DATABASE [{Database}]");
            }

            // PASO 2: Crear tablas EN ORDEN (padres primero, hijos después)
            using (var conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                // 1. USUARIO
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Usuario' AND xtype='U')
                CREATE TABLE [dbo].[Usuario](
                    [IdUsuario]      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [NombreUsuario]  NVARCHAR(100) NOT NULL UNIQUE,
                    [Contrasena]     NVARCHAR(255) NOT NULL,
                    [NombreCompleto] NVARCHAR(150) NULL,
                    [Rol]            NVARCHAR(50)  NULL,
                    [Estado]         NVARCHAR(20)  NULL DEFAULT('Activo')
                );");

                // 2. EMPLEADO
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Empleado' AND xtype='U')
                CREATE TABLE [dbo].[Empleado](
                    [IdEmpleado]   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]       NVARCHAR(100) NOT NULL,
                    [Apellido]     NVARCHAR(100) NOT NULL,
                    [Cargo]        NVARCHAR(100) NOT NULL,
                    [FechaIngreso] DATE NOT NULL,
                    [Telefono]     NVARCHAR(20)  NULL,
                    [Email]        NVARCHAR(150) NULL,
                    [Estado]       NVARCHAR(20)  NOT NULL DEFAULT('Activo')
                );");

                // 3. VISITANTE
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Visitante' AND xtype='U')
                CREATE TABLE [dbo].[Visitante](
                    [IdVisitante]        INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]             NVARCHAR(100) NOT NULL,
                    [Apellido]           NVARCHAR(100) NOT NULL,
                    [DocumentoIdentidad] NVARCHAR(50)  NULL,
                    [Edad]               INT NULL,
                    [Genero]             NVARCHAR(20)  NULL,
                    [Nacionalidad]       NVARCHAR(100) NULL,
                    [Telefono]           NVARCHAR(20)  NULL,
                    [Email]              NVARCHAR(150) NULL
                );");

                // 4. PROVEEDOR
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Proveedor' AND xtype='U')
                CREATE TABLE [dbo].[Proveedor](
                    [IdProveedor]   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [RazonSocial]   NVARCHAR(200) NOT NULL,
                    [RNC]           NVARCHAR(20)  NULL,
                    [Contacto]      NVARCHAR(150) NULL,
                    [Telefono]      NVARCHAR(20)  NULL,
                    [Email]         NVARCHAR(150) NULL,
                    [Direccion]     NVARCHAR(300) NULL,
                    [Categoria]     NVARCHAR(100) NULL,
                    [Estado]        NVARCHAR(20)  NOT NULL DEFAULT('Activo'),
                    [FechaRegistro] DATE NOT NULL DEFAULT(GETDATE())
                );");

                // 5. SALA
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Sala' AND xtype='U')
                CREATE TABLE [dbo].[Sala](
                    [IdSala]      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]      NVARCHAR(100) NOT NULL,
                    [Capacidad]   INT NULL,
                    [Ubicacion]   NVARCHAR(200) NULL,
                    [Tipo]        NVARCHAR(50)  NULL,
                    [Estado]      NVARCHAR(50)  NULL,
                    [Descripcion] NVARCHAR(500) NULL
                );");

                // 6. GUIA → FK Empleado
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Guia' AND xtype='U')
                CREATE TABLE [dbo].[Guia](
                    [IdGuia]     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]     NVARCHAR(100) NOT NULL,
                    [Apellido]   NVARCHAR(100) NOT NULL,
                    [Telefono]   NVARCHAR(20)  NULL,
                    [Email]      NVARCHAR(150) NULL,
                    [Idioma]     NVARCHAR(100) NULL,
                    [Estado]     NVARCHAR(20)  NOT NULL DEFAULT('Activo'),
                    [IdEmpleado] INT NULL,
                    CONSTRAINT FK_Guia_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado)
                );");

                // 7. INVENTARIO → FK Empleado
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Inventario' AND xtype='U')
                CREATE TABLE [dbo].[Inventario](
                    [IdInventario]     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]           NVARCHAR(200) NOT NULL,
                    [CodigoInventario] NVARCHAR(50)  NULL,
                    [Categoria]        NVARCHAR(100) NULL,
                    [Epoca]            NVARCHAR(100) NULL,
                    [Material]         NVARCHAR(100) NULL,
                    [Ubicacion]        NVARCHAR(200) NULL,
                    [ValorEstimado]    DECIMAL(18,2) NULL,
                    [Estado]           NVARCHAR(50)  NULL,
                    [FechaIngreso]     DATE NULL,
                    [Descripcion]      NVARCHAR(500) NULL,
                    [IdEmpleado]       INT NULL,
                    CONSTRAINT FK_Inventario_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado)
                );");

                // 8. EXPOSICION → FK Sala
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Exposicion' AND xtype='U')
                CREATE TABLE [dbo].[Exposicion](
                    [IdExposicion] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]       NVARCHAR(200) NOT NULL,
                    [Descripcion]  NVARCHAR(500) NULL,
                    [FechaInicio]  DATE NOT NULL,
                    [FechaFin]     DATE NOT NULL,
                    [Estado]       NVARCHAR(50)  NULL,
                    [Responsable]  NVARCHAR(200) NULL,
                    [IdSala]       INT NULL,
                    CONSTRAINT FK_Exposicion_Sala FOREIGN KEY (IdSala) REFERENCES Sala(IdSala)
                );");

                // 9. PIEZA → FK Sala
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Pieza' AND xtype='U')
                CREATE TABLE [dbo].[Pieza](
                    [IdPieza]            INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]             NVARCHAR(200) NOT NULL,
                    [Descripcion]        NVARCHAR(500) NULL,
                    [Epoca]              NVARCHAR(100) NULL,
                    [Material]           NVARCHAR(100) NULL,
                    [EstadoConservacion] NVARCHAR(50)  NULL,
                    [Ubicacion]          NVARCHAR(200) NULL,
                    [ValorEstimado]      DECIMAL(18,2) NULL,
                    [IdSala]             INT NULL,
                    CONSTRAINT FK_Pieza_Sala FOREIGN KEY (IdSala) REFERENCES Sala(IdSala)
                );");

                // Migración: agregar Ubicacion si la tabla ya existía sin esa columna
                Exec(conn, @"IF NOT EXISTS (
                    SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME='Pieza' AND COLUMN_NAME='Ubicacion')
                ALTER TABLE [dbo].[Pieza] ADD [Ubicacion] NVARCHAR(200) NULL;");

                // 10. EVENTO → FK Sala
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Evento' AND xtype='U')
                CREATE TABLE [dbo].[Evento](
                    [IdEvento]        INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Nombre]          NVARCHAR(200) NOT NULL,
                    [Tipo]            NVARCHAR(100) NULL,
                    [Responsable]     NVARCHAR(200) NULL,
                    [CapacidadMaxima] INT NULL,
                    [FechaInicio]     DATE NOT NULL,
                    [FechaFin]        DATE NOT NULL,
                    [Estado]          NVARCHAR(50)  NULL,
                    [Descripcion]     NVARCHAR(500) NULL,
                    [IdSala]          INT NULL,
                    CONSTRAINT FK_Evento_Sala FOREIGN KEY (IdSala) REFERENCES Sala(IdSala)
                );");

                // 11. CONTRATO → FK Proveedor
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contrato' AND xtype='U')
                CREATE TABLE [dbo].[Contrato](
                    [IdContrato]       INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [NumeroContrato]   NVARCHAR(50)  NULL,
                    [Descripcion]      NVARCHAR(500) NULL,
                    [Tipo]             NVARCHAR(100) NULL,
                    [MontoTotal]       DECIMAL(18,2) NULL,
                    [FechaInicio]      DATE NOT NULL,
                    [FechaVencimiento] DATE NOT NULL,
                    [Estado]           NVARCHAR(50)  NULL,
                    [Observaciones]    NVARCHAR(500) NULL,
                    [IdProveedor]      INT NOT NULL,
                    CONSTRAINT FK_Contrato_Proveedor FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor)
                );");

                // 12. MANTENIMIENTO → FK Empleado + Sala
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Mantenimiento' AND xtype='U')
                CREATE TABLE [dbo].[Mantenimiento](
                    [IdMantenimiento]   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [TipoMantenimiento] NVARCHAR(100) NULL,
                    [Descripcion]       NVARCHAR(500) NULL,
                    [FechaInicio]       DATE NOT NULL,
                    [FechaFin]          DATE NULL,
                    [Costo]             DECIMAL(18,2) NULL,
                    [Estado]            NVARCHAR(50)  NULL,
                    [Observaciones]     NVARCHAR(500) NULL,
                    [IdEmpleado]        INT NULL,
                    [IdSala]            INT NULL,
                    CONSTRAINT FK_Mantenimiento_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado),
                    CONSTRAINT FK_Mantenimiento_Sala     FOREIGN KEY (IdSala)     REFERENCES Sala(IdSala)
                );");

                // 13. ENTRADA → FK Visitante
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Entrada' AND xtype='U')
                CREATE TABLE [dbo].[Entrada](
                    [IdEntrada]     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Tipo]          NVARCHAR(50)  NULL,
                    [Precio]        DECIMAL(18,2) NULL,
                    [Cantidad]      INT NULL,
                    [Fecha]         DATE NOT NULL,
                    [MetodoPago]    NVARCHAR(50)  NULL,
                    [Observaciones] NVARCHAR(500) NULL,
                    [IdVisitante]   INT NULL,
                    CONSTRAINT FK_Entrada_Visitante FOREIGN KEY (IdVisitante) REFERENCES Visitante(IdVisitante)
                );");

                // 14. RESERVA → FK Visitante
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Reserva' AND xtype='U')
                CREATE TABLE [dbo].[Reserva](
                    [IdReserva]        INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [CantidadPersonas] INT NULL,
                    [FechaReserva]     DATE NOT NULL,
                    [Hora]             DATETIME NULL,
                    [Tipo]             NVARCHAR(100) NULL,
                    [Estado]           NVARCHAR(50)  NULL,
                    [Observaciones]    NVARCHAR(500) NULL,
                    [IdVisitante]      INT NULL,
                    CONSTRAINT FK_Reserva_Visitante FOREIGN KEY (IdVisitante) REFERENCES Visitante(IdVisitante)
                );");

                // 15. DONACION (independiente)
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Donacion' AND xtype='U')
                CREATE TABLE [dbo].[Donacion](
                    [IdDonacion]      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [NombreDonante]   NVARCHAR(200) NOT NULL,
                    [EmailDonante]    NVARCHAR(150) NULL,
                    [TelefonoDonante] NVARCHAR(20)  NULL,
                    [Tipo]            NVARCHAR(100) NULL,
                    [Descripcion]     NVARCHAR(500) NULL,
                    [ValorEstimado]   DECIMAL(18,2) NULL,
                    [FechaDonacion]   DATE NOT NULL,
                    [Estado]          NVARCHAR(50)  NULL
                );");

                // 16. PRESTAMO → FK Pieza
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Prestamo' AND xtype='U')
                CREATE TABLE [dbo].[Prestamo](
                    [IdPrestamo]             INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [InstitucionSolicitante] NVARCHAR(200) NULL,
                    [Responsable]            NVARCHAR(200) NULL,
                    [Contacto]               NVARCHAR(200) NULL,
                    [FechaPrestamo]          DATE NOT NULL,
                    [FechaDevolucion]        DATE NOT NULL,
                    [Estado]                 NVARCHAR(50)  NULL,
                    [Condiciones]            NVARCHAR(500) NULL,
                    [IdPieza]                INT NULL,
                    CONSTRAINT FK_Prestamo_Pieza  FOREIGN KEY (IdPieza) REFERENCES Pieza(IdPieza),
                    CONSTRAINT CHK_Prestamo_Fechas CHECK (FechaDevolucion > FechaPrestamo)
                );");

                // 17. REPORTE → FK Empleado
                Exec(conn, @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Reporte' AND xtype='U')
                CREATE TABLE [dbo].[Reporte](
                    [IdReporte]       INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Titulo]          NVARCHAR(200) NOT NULL,
                    [Tipo]            NVARCHAR(100) NULL,
                    [FechaGeneracion] DATE NOT NULL DEFAULT(GETDATE()),
                    [GeneradoPor]     NVARCHAR(150) NULL,
                    [PeriodoDesde]    DATE NULL,
                    [PeriodoHasta]    DATE NULL,
                    [Descripcion]     NVARCHAR(500) NULL,
                    [Estado]          NVARCHAR(50)  NULL,
                    [IdEmpleado]      INT NULL,
                    CONSTRAINT FK_Reporte_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado)
                );");

                // Admin por defecto
                Exec(conn, @"IF NOT EXISTS (SELECT 1 FROM [dbo].[Usuario] WHERE NombreUsuario = 'admin')
                INSERT INTO [dbo].[Usuario] (NombreUsuario, Contrasena, NombreCompleto, Rol, Estado)
                VALUES ('admin', '1234', 'Administrador del Sistema', 'Admin', 'Activo');");
            }

            _inicializado = true;
        }

        private static void Exec(SqlConnection conn, string sql)
        {
            using (var cmd = new SqlCommand(sql, conn))
                cmd.ExecuteNonQuery();
        }
    }
}
