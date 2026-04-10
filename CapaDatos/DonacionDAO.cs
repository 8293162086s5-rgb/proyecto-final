using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class DonacionDAO
    {
        public void Agregar(Donacion don)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Donacion (NombreDonante, EmailDonante, TelefonoDonante, Tipo, Descripcion, ValorEstimado, FechaDonacion, Estado)
                                 VALUES (@NombreDonante, @EmailDonante, @TelefonoDonante, @Tipo, @Descripcion, @ValorEstimado, @FechaDonacion, @Estado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreDonante",   don.NombreDonante);
                cmd.Parameters.AddWithValue("@EmailDonante",    don.EmailDonante    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TelefonoDonante", don.TelefonoDonante ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo",            don.Tipo);
                cmd.Parameters.AddWithValue("@Descripcion",     don.Descripcion);
                cmd.Parameters.AddWithValue("@ValorEstimado",   don.ValorEstimado);
                cmd.Parameters.AddWithValue("@FechaDonacion",   don.FechaDonacion);
                cmd.Parameters.AddWithValue("@Estado",          don.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Donacion> Listar()
        {
            List<Donacion> lista = new List<Donacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdDonacion, NombreDonante, EmailDonante, TelefonoDonante, Tipo, Descripcion, ValorEstimado, FechaDonacion, Estado FROM Donacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Donacion
                    {
                        IdDonacion      = Convert.ToInt32(reader["IdDonacion"]),
                        NombreDonante   = reader["NombreDonante"].ToString(),
                        EmailDonante    = reader["EmailDonante"].ToString(),
                        TelefonoDonante = reader["TelefonoDonante"].ToString(),
                        Tipo            = reader["Tipo"].ToString(),
                        Descripcion     = reader["Descripcion"].ToString(),
                        ValorEstimado   = Convert.ToDecimal(reader["ValorEstimado"]),
                        FechaDonacion   = Convert.ToDateTime(reader["FechaDonacion"]),
                        Estado          = reader["Estado"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Donacion don)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Donacion SET NombreDonante=@NombreDonante, EmailDonante=@EmailDonante,
                                 TelefonoDonante=@TelefonoDonante, Tipo=@Tipo, Descripcion=@Descripcion,
                                 ValorEstimado=@ValorEstimado, FechaDonacion=@FechaDonacion, Estado=@Estado
                                 WHERE IdDonacion=@IdDonacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdDonacion",      don.IdDonacion);
                cmd.Parameters.AddWithValue("@NombreDonante",   don.NombreDonante);
                cmd.Parameters.AddWithValue("@EmailDonante",    don.EmailDonante    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TelefonoDonante", don.TelefonoDonante ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo",            don.Tipo);
                cmd.Parameters.AddWithValue("@Descripcion",     don.Descripcion);
                cmd.Parameters.AddWithValue("@ValorEstimado",   don.ValorEstimado);
                cmd.Parameters.AddWithValue("@FechaDonacion",   don.FechaDonacion);
                cmd.Parameters.AddWithValue("@Estado",          don.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idDonacion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Donacion WHERE IdDonacion=@IdDonacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdDonacion", idDonacion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
