using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class PrestamoDAO
    {
        public void Agregar(Prestamo pre)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO Prestamo
                    (IdPieza,InstitucionSolicitante,Responsable,Contacto,FechaPrestamo,FechaDevolucion,Estado,Condiciones)
                    VALUES(@IdPieza,@Inst,@Resp,@Contacto,@FechaP,@FechaD,@Estado,@Cond)", conn);
                cmd.Parameters.AddWithValue("@IdPieza",  pre.IdPieza > 0 ? (object)pre.IdPieza : DBNull.Value);
                cmd.Parameters.AddWithValue("@Inst",     pre.InstitucionSolicitante);
                cmd.Parameters.AddWithValue("@Resp",     pre.Responsable);
                cmd.Parameters.AddWithValue("@Contacto", pre.Contacto    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaP",   pre.FechaPrestamo);
                cmd.Parameters.AddWithValue("@FechaD",   pre.FechaDevolucion);
                cmd.Parameters.AddWithValue("@Estado",   pre.Estado);
                cmd.Parameters.AddWithValue("@Cond",     pre.Condiciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Prestamo> Listar()
        {
            var lista = new List<Prestamo>();
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var reader = new SqlCommand(@"
                    SELECT p.IdPrestamo,p.IdPieza,ISNULL(pi.Nombre,'') AS NombrePieza,
                           p.InstitucionSolicitante,p.Responsable,p.Contacto,
                           p.FechaPrestamo,p.FechaDevolucion,p.Estado,p.Condiciones
                    FROM Prestamo p
                    LEFT JOIN Pieza pi ON p.IdPieza=pi.IdPieza
                    ORDER BY p.FechaPrestamo DESC", conn).ExecuteReader();
                while (reader.Read())
                    lista.Add(new Prestamo {
                        IdPrestamo             = Convert.ToInt32(reader["IdPrestamo"]),
                        IdPieza                = reader["IdPieza"]==DBNull.Value ? 0 : Convert.ToInt32(reader["IdPieza"]),
                        NombrePieza            = reader["NombrePieza"].ToString(),
                        InstitucionSolicitante = reader["InstitucionSolicitante"].ToString(),
                        Responsable            = reader["Responsable"].ToString(),
                        Contacto               = reader["Contacto"].ToString(),
                        FechaPrestamo          = Convert.ToDateTime(reader["FechaPrestamo"]),
                        FechaDevolucion        = Convert.ToDateTime(reader["FechaDevolucion"]),
                        Estado                 = reader["Estado"].ToString(),
                        Condiciones            = reader["Condiciones"].ToString()
                    });
            }
            return lista;
        }

        public void Actualizar(Prestamo pre)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE Prestamo SET IdPieza=@IdPieza,
                    InstitucionSolicitante=@Inst,Responsable=@Resp,Contacto=@Contacto,
                    FechaPrestamo=@FechaP,FechaDevolucion=@FechaD,Estado=@Estado,Condiciones=@Cond
                    WHERE IdPrestamo=@IdPrestamo", conn);
                cmd.Parameters.AddWithValue("@IdPrestamo", pre.IdPrestamo);
                cmd.Parameters.AddWithValue("@IdPieza",    pre.IdPieza > 0 ? (object)pre.IdPieza : DBNull.Value);
                cmd.Parameters.AddWithValue("@Inst",       pre.InstitucionSolicitante);
                cmd.Parameters.AddWithValue("@Resp",       pre.Responsable);
                cmd.Parameters.AddWithValue("@Contacto",   pre.Contacto    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaP",     pre.FechaPrestamo);
                cmd.Parameters.AddWithValue("@FechaD",     pre.FechaDevolucion);
                cmd.Parameters.AddWithValue("@Estado",     pre.Estado);
                cmd.Parameters.AddWithValue("@Cond",       pre.Condiciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Prestamo WHERE IdPrestamo=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
