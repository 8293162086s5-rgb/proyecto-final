using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class MantenimientoDAO
    {
        public void Agregar(Mantenimiento m)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO Mantenimiento
                    (TipoMantenimiento,Descripcion,FechaInicio,FechaFin,Costo,Estado,Observaciones,IdEmpleado,IdSala)
                    VALUES(@Tipo,@Desc,@FechaInicio,@FechaFin,@Costo,@Estado,@Obs,@IdEmpleado,@IdSala)", conn);
                cmd.Parameters.AddWithValue("@Tipo",       m.TipoMantenimiento);
                cmd.Parameters.AddWithValue("@Desc",       m.Descripcion   ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaInicio",m.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",   m.FechaFin == DateTime.MinValue ? (object)DBNull.Value : m.FechaFin);
                cmd.Parameters.AddWithValue("@Costo",      m.Costo);
                cmd.Parameters.AddWithValue("@Estado",     m.Estado);
                cmd.Parameters.AddWithValue("@Obs",        m.Observaciones ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdEmpleado", m.IdEmpleado > 0 ? (object)m.IdEmpleado : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdSala",     m.IdSala     > 0 ? (object)m.IdSala     : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Mantenimiento> Listar()
        {
            var lista = new List<Mantenimiento>();
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var reader = new SqlCommand(@"
                    SELECT m.IdMantenimiento,m.TipoMantenimiento,m.Descripcion,
                           m.FechaInicio,m.FechaFin,m.Costo,m.Estado,m.Observaciones,
                           m.IdEmpleado,m.IdSala,
                           ISNULL(e.Nombre+' '+e.Apellido,'') AS NombreEmpleado,
                           ISNULL(s.Nombre,'')                AS NombreSala
                    FROM Mantenimiento m
                    LEFT JOIN Empleado e ON m.IdEmpleado=e.IdEmpleado
                    LEFT JOIN Sala     s ON m.IdSala=s.IdSala
                    ORDER BY m.FechaInicio DESC", conn).ExecuteReader();
                while (reader.Read())
                    lista.Add(new Mantenimiento {
                        IdMantenimiento   = Convert.ToInt32(reader["IdMantenimiento"]),
                        TipoMantenimiento = reader["TipoMantenimiento"].ToString(),
                        Descripcion       = reader["Descripcion"].ToString(),
                        FechaInicio       = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin          = reader["FechaFin"]==DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["FechaFin"]),
                        Costo             = Convert.ToDecimal(reader["Costo"]),
                        Estado            = reader["Estado"].ToString(),
                        Observaciones     = reader["Observaciones"].ToString(),
                        IdEmpleado        = reader["IdEmpleado"]==DBNull.Value ? 0 : Convert.ToInt32(reader["IdEmpleado"]),
                        IdSala            = reader["IdSala"]    ==DBNull.Value ? 0 : Convert.ToInt32(reader["IdSala"]),
                        NombreEmpleado    = reader["NombreEmpleado"].ToString(),
                        NombreSala        = reader["NombreSala"].ToString()
                    });
            }
            return lista;
        }

        public void Actualizar(Mantenimiento m)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE Mantenimiento SET
                    TipoMantenimiento=@Tipo,Descripcion=@Desc,FechaInicio=@FechaInicio,FechaFin=@FechaFin,
                    Costo=@Costo,Estado=@Estado,Observaciones=@Obs,IdEmpleado=@IdEmpleado,IdSala=@IdSala
                    WHERE IdMantenimiento=@Id", conn);
                cmd.Parameters.AddWithValue("@Id",         m.IdMantenimiento);
                cmd.Parameters.AddWithValue("@Tipo",       m.TipoMantenimiento);
                cmd.Parameters.AddWithValue("@Desc",       m.Descripcion   ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaInicio",m.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",   m.FechaFin == DateTime.MinValue ? (object)DBNull.Value : m.FechaFin);
                cmd.Parameters.AddWithValue("@Costo",      m.Costo);
                cmd.Parameters.AddWithValue("@Estado",     m.Estado);
                cmd.Parameters.AddWithValue("@Obs",        m.Observaciones ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdEmpleado", m.IdEmpleado > 0 ? (object)m.IdEmpleado : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdSala",     m.IdSala     > 0 ? (object)m.IdSala     : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Mantenimiento WHERE IdMantenimiento=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
