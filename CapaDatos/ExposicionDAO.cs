using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ExposicionDAO
    {
        public void Agregar(Exposicion expo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Exposicion (IdSala, Nombre, Descripcion, FechaInicio, FechaFin, Estado, Responsable)
                                 VALUES (@IdSala, @Nombre, @Descripcion, @FechaInicio, @FechaFin, @Estado, @Responsable)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdSala",      expo.IdSala);
                cmd.Parameters.AddWithValue("@Nombre",      expo.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", expo.Descripcion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaInicio", expo.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",    expo.FechaFin);
                cmd.Parameters.AddWithValue("@Estado",      expo.Estado);
                cmd.Parameters.AddWithValue("@Responsable", expo.Responsable);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Exposicion> Listar()
        {
            List<Exposicion> lista = new List<Exposicion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT e.IdExposicion, e.IdSala,
                                        s.Nombre AS NombreSala,
                                        e.Nombre, e.Descripcion, e.FechaInicio, e.FechaFin, e.Estado, e.Responsable
                                 FROM Exposicion e
                                 INNER JOIN Sala s ON e.IdSala = s.IdSala
                                 ORDER BY e.FechaInicio DESC";
                SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Exposicion
                    {
                        IdExposicion = Convert.ToInt32(reader["IdExposicion"]),
                        IdSala       = Convert.ToInt32(reader["IdSala"]),
                        NombreSala   = reader["NombreSala"].ToString(),
                        Nombre       = reader["Nombre"].ToString(),
                        Descripcion  = reader["Descripcion"].ToString(),
                        FechaInicio  = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin     = Convert.ToDateTime(reader["FechaFin"]),
                        Estado       = reader["Estado"].ToString(),
                        Responsable  = reader["Responsable"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Exposicion expo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Exposicion SET IdSala=@IdSala, Nombre=@Nombre, Descripcion=@Descripcion,
                                 FechaInicio=@FechaInicio, FechaFin=@FechaFin, Estado=@Estado, Responsable=@Responsable
                                 WHERE IdExposicion=@IdExposicion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdExposicion", expo.IdExposicion);
                cmd.Parameters.AddWithValue("@IdSala",       expo.IdSala);
                cmd.Parameters.AddWithValue("@Nombre",       expo.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion",  expo.Descripcion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaInicio",  expo.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",     expo.FechaFin);
                cmd.Parameters.AddWithValue("@Estado",       expo.Estado);
                cmd.Parameters.AddWithValue("@Responsable",  expo.Responsable);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idExposicion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Exposicion WHERE IdExposicion=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", idExposicion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
