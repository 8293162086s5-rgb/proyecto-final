using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class VisitanteDAO
    {
        public void Agregar(Visitante vis)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Visitante (Nombre, Apellido, DocumentoIdentidad, Edad, Genero, Nacionalidad, Email)
                                 VALUES (@Nombre, @Apellido, @DocumentoIdentidad, @Edad, @Genero, @Nacionalidad, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre",             vis.Nombre);
                cmd.Parameters.AddWithValue("@Apellido",           vis.Apellido);
                cmd.Parameters.AddWithValue("@DocumentoIdentidad", vis.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@Edad",               vis.Edad);
                cmd.Parameters.AddWithValue("@Genero",             vis.Genero);
                cmd.Parameters.AddWithValue("@Nacionalidad",       vis.Nacionalidad);
                cmd.Parameters.AddWithValue("@Email",              vis.Email ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Visitante> Listar()
        {
            List<Visitante> lista = new List<Visitante>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdVisitante, Nombre, Apellido, DocumentoIdentidad, Edad, Genero, Nacionalidad, Email FROM Visitante";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Visitante
                    {
                        IdVisitante        = Convert.ToInt32(reader["IdVisitante"]),
                        Nombre             = reader["Nombre"].ToString(),
                        Apellido           = reader["Apellido"].ToString(),
                        DocumentoIdentidad = reader["DocumentoIdentidad"].ToString(),
                        Edad               = Convert.ToInt32(reader["Edad"]),
                        Genero             = reader["Genero"].ToString(),
                        Nacionalidad       = reader["Nacionalidad"].ToString(),
                        Email              = reader["Email"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Visitante vis)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Visitante SET Nombre=@Nombre, Apellido=@Apellido,
                                 DocumentoIdentidad=@DocumentoIdentidad, Edad=@Edad,
                                 Genero=@Genero, Nacionalidad=@Nacionalidad, Email=@Email
                                 WHERE IdVisitante=@IdVisitante";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVisitante",        vis.IdVisitante);
                cmd.Parameters.AddWithValue("@Nombre",             vis.Nombre);
                cmd.Parameters.AddWithValue("@Apellido",           vis.Apellido);
                cmd.Parameters.AddWithValue("@DocumentoIdentidad", vis.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@Edad",               vis.Edad);
                cmd.Parameters.AddWithValue("@Genero",             vis.Genero);
                cmd.Parameters.AddWithValue("@Nacionalidad",       vis.Nacionalidad);
                cmd.Parameters.AddWithValue("@Email",              vis.Email ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idVisitante)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Visitante WHERE IdVisitante=@IdVisitante";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVisitante", idVisitante);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
