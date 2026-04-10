using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ProveedorDAO
    {
        public void Agregar(Proveedor prov)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Proveedor
                                 (RazonSocial, RNC, Contacto, Telefono, Email,
                                  Direccion, Categoria, Estado, FechaRegistro)
                                 VALUES (@RazonSocial, @RNC, @Contacto, @Telefono, @Email,
                                         @Direccion, @Categoria, @Estado, @FechaRegistro)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RazonSocial",    prov.RazonSocial);
                cmd.Parameters.AddWithValue("@RNC",            prov.RNC            ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Contacto",       prov.Contacto       ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono",       prov.Telefono       ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",          prov.Email          ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion",      prov.Direccion      ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Categoria",      prov.Categoria);
                cmd.Parameters.AddWithValue("@Estado",         prov.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro",  prov.FechaRegistro);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT IdProveedor, RazonSocial, RNC, Contacto, Telefono,
                                        Email, Direccion, Categoria, Estado, FechaRegistro
                                 FROM Proveedor ORDER BY RazonSocial";
                SqlCommand    cmd    = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProveedor    = Convert.ToInt32(reader["IdProveedor"]),
                        RazonSocial    = reader["RazonSocial"].ToString(),
                        RNC            = reader["RNC"].ToString(),
                        Contacto       = reader["Contacto"].ToString(),
                        Telefono       = reader["Telefono"].ToString(),
                        Email          = reader["Email"].ToString(),
                        Direccion      = reader["Direccion"].ToString(),
                        Categoria      = reader["Categoria"].ToString(),
                        Estado         = reader["Estado"].ToString(),
                        FechaRegistro  = Convert.ToDateTime(reader["FechaRegistro"])
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Proveedor prov)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Proveedor SET
                                 RazonSocial=@RazonSocial, RNC=@RNC, Contacto=@Contacto,
                                 Telefono=@Telefono, Email=@Email, Direccion=@Direccion,
                                 Categoria=@Categoria, Estado=@Estado, FechaRegistro=@FechaRegistro
                                 WHERE IdProveedor=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id",             prov.IdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial",    prov.RazonSocial);
                cmd.Parameters.AddWithValue("@RNC",            prov.RNC            ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Contacto",       prov.Contacto       ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono",       prov.Telefono       ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",          prov.Email          ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion",      prov.Direccion      ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Categoria",      prov.Categoria);
                cmd.Parameters.AddWithValue("@Estado",         prov.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro",  prov.FechaRegistro);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idProveedor)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string     query = "DELETE FROM Proveedor WHERE IdProveedor=@Id";
                SqlCommand cmd   = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idProveedor);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
