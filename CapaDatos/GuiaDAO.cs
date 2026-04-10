using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class GuiaDAO
    {
        public void Agregar(Guia guia)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO Guia (Nombre,Apellido,Telefono,Email,Idioma,Estado,IdEmpleado)
                    VALUES (@Nombre,@Apellido,@Telefono,@Email,@Idioma,@Estado,@IdEmpleado)", conn);
                cmd.Parameters.AddWithValue("@Nombre",     guia.Nombre);
                cmd.Parameters.AddWithValue("@Apellido",   guia.Apellido);
                cmd.Parameters.AddWithValue("@Telefono",   guia.Telefono  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",      guia.Email     ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Idioma",     guia.Idioma);
                cmd.Parameters.AddWithValue("@Estado",     guia.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", guia.IdEmpleado > 0 ? (object)guia.IdEmpleado : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Guia> Listar()
        {
            var lista = new List<Guia>();
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var reader = new SqlCommand(@"
                    SELECT g.IdGuia,g.Nombre,g.Apellido,g.Telefono,g.Email,g.Idioma,g.Estado,g.IdEmpleado,
                           ISNULL(e.Nombre+' '+e.Apellido,'') AS NombreEmpleado
                    FROM Guia g
                    LEFT JOIN Empleado e ON g.IdEmpleado=e.IdEmpleado
                    ORDER BY g.Apellido", conn).ExecuteReader();
                while (reader.Read())
                    lista.Add(new Guia {
                        IdGuia         = Convert.ToInt32(reader["IdGuia"]),
                        Nombre         = reader["Nombre"].ToString(),
                        Apellido       = reader["Apellido"].ToString(),
                        Telefono       = reader["Telefono"].ToString(),
                        Email          = reader["Email"].ToString(),
                        Idioma         = reader["Idioma"].ToString(),
                        Estado         = reader["Estado"].ToString(),
                        IdEmpleado     = reader["IdEmpleado"]==DBNull.Value ? 0 : Convert.ToInt32(reader["IdEmpleado"]),
                        NombreEmpleado = reader["NombreEmpleado"].ToString()
                    });
            }
            return lista;
        }

        public void Actualizar(Guia guia)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE Guia SET Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono,
                    Email=@Email,Idioma=@Idioma,Estado=@Estado,IdEmpleado=@IdEmpleado WHERE IdGuia=@IdGuia", conn);
                cmd.Parameters.AddWithValue("@IdGuia",     guia.IdGuia);
                cmd.Parameters.AddWithValue("@Nombre",     guia.Nombre);
                cmd.Parameters.AddWithValue("@Apellido",   guia.Apellido);
                cmd.Parameters.AddWithValue("@Telefono",   guia.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",      guia.Email    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Idioma",     guia.Idioma);
                cmd.Parameters.AddWithValue("@Estado",     guia.Estado);
                cmd.Parameters.AddWithValue("@IdEmpleado", guia.IdEmpleado > 0 ? (object)guia.IdEmpleado : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Guia WHERE IdGuia=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
