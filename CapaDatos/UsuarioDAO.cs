using System;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class UsuarioDAO
    {
        public Usuario Login(string nombreUsuario, string contrasena)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT IdUsuario, NombreUsuario, Contrasena, NombreCompleto, Rol, Estado
                                 FROM Usuario
                                 WHERE NombreUsuario = @NombreUsuario
                                 AND Contrasena = @Contrasena
                                 AND Estado = 'Activo'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena",    contrasena);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario      = Convert.ToInt32(reader["IdUsuario"]),
                        NombreUsuario  = reader["NombreUsuario"].ToString(),
                        Contrasena     = reader["Contrasena"].ToString(),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        Rol            = reader["Rol"].ToString(),
                        Estado         = reader["Estado"].ToString()
                    };
                }
                return null;
            }
        }
    }
}
