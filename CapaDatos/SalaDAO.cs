using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class SalaDAO
    {
        public void Agregar(Sala sala)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Sala (Nombre, Capacidad, Ubicacion, Tipo, Estado, Descripcion)
                                 VALUES (@Nombre, @Capacidad, @Ubicacion, @Tipo, @Estado, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre",      sala.Nombre);
                cmd.Parameters.AddWithValue("@Capacidad",   sala.Capacidad);
                cmd.Parameters.AddWithValue("@Ubicacion",   sala.Ubicacion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo",        sala.Tipo);
                cmd.Parameters.AddWithValue("@Estado",      sala.Estado);
                cmd.Parameters.AddWithValue("@Descripcion", sala.Descripcion ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Sala> Listar()
        {
            List<Sala> lista = new List<Sala>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdSala, Nombre, Capacidad, Ubicacion, Tipo, Estado, Descripcion FROM Sala";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Sala
                    {
                        IdSala      = Convert.ToInt32(reader["IdSala"]),
                        Nombre      = reader["Nombre"].ToString(),
                        Capacidad   = Convert.ToInt32(reader["Capacidad"]),
                        Ubicacion   = reader["Ubicacion"].ToString(),
                        Tipo        = reader["Tipo"].ToString(),
                        Estado      = reader["Estado"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Sala sala)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Sala SET Nombre=@Nombre, Capacidad=@Capacidad, Ubicacion=@Ubicacion,
                                 Tipo=@Tipo, Estado=@Estado, Descripcion=@Descripcion
                                 WHERE IdSala=@IdSala";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdSala",      sala.IdSala);
                cmd.Parameters.AddWithValue("@Nombre",      sala.Nombre);
                cmd.Parameters.AddWithValue("@Capacidad",   sala.Capacidad);
                cmd.Parameters.AddWithValue("@Ubicacion",   sala.Ubicacion   ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo",        sala.Tipo);
                cmd.Parameters.AddWithValue("@Estado",      sala.Estado);
                cmd.Parameters.AddWithValue("@Descripcion", sala.Descripcion ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idSala)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Sala WHERE IdSala=@IdSala";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdSala", idSala);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
