using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ContratoDAO
    {
        public void Agregar(Contrato cont)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Contrato (IdProveedor, NumeroContrato, Descripcion, Tipo, MontoTotal, FechaInicio, FechaVencimiento, Estado, Observaciones)
                                 VALUES (@IdProveedor, @Numero, @Descripcion, @Tipo, @Monto, @FechaInicio, @FechaVenc, @Estado, @Obs)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProveedor",  cont.IdProveedor);
                cmd.Parameters.AddWithValue("@Numero",       cont.NumeroContrato);
                cmd.Parameters.AddWithValue("@Descripcion",  cont.Descripcion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo",         cont.Tipo);
                cmd.Parameters.AddWithValue("@Monto",        cont.MontoTotal);
                cmd.Parameters.AddWithValue("@FechaInicio",  cont.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaVenc",    cont.FechaVencimiento);
                cmd.Parameters.AddWithValue("@Estado",       cont.Estado);
                cmd.Parameters.AddWithValue("@Obs",          cont.Observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Contrato> Listar()
        {
            List<Contrato> lista = new List<Contrato>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT c.IdContrato, c.IdProveedor,
                                        p.RazonSocial AS NombreProveedor,
                                        c.NumeroContrato, c.Descripcion, c.Tipo,
                                        c.MontoTotal, c.FechaInicio, c.FechaVencimiento, c.Estado, c.Observaciones
                                 FROM Contrato c
                                 INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor
                                 ORDER BY c.FechaVencimiento";
                SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Contrato
                    {
                        IdContrato       = Convert.ToInt32(reader["IdContrato"]),
                        IdProveedor      = Convert.ToInt32(reader["IdProveedor"]),
                        NombreProveedor  = reader["NombreProveedor"].ToString(),
                        NumeroContrato   = reader["NumeroContrato"].ToString(),
                        Descripcion      = reader["Descripcion"].ToString(),
                        Tipo             = reader["Tipo"].ToString(),
                        MontoTotal       = Convert.ToDecimal(reader["MontoTotal"]),
                        FechaInicio      = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]),
                        Estado           = reader["Estado"].ToString(),
                        Observaciones    = reader["Observaciones"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Contrato cont)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Contrato SET IdProveedor=@IdProveedor, NumeroContrato=@Numero,
                                 Descripcion=@Descripcion, Tipo=@Tipo, MontoTotal=@Monto,
                                 FechaInicio=@FechaInicio, FechaVencimiento=@FechaVenc,
                                 Estado=@Estado, Observaciones=@Obs
                                 WHERE IdContrato=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id",           cont.IdContrato);
                cmd.Parameters.AddWithValue("@IdProveedor",  cont.IdProveedor);
                cmd.Parameters.AddWithValue("@Numero",       cont.NumeroContrato);
                cmd.Parameters.AddWithValue("@Descripcion",  cont.Descripcion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo",         cont.Tipo);
                cmd.Parameters.AddWithValue("@Monto",        cont.MontoTotal);
                cmd.Parameters.AddWithValue("@FechaInicio",  cont.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaVenc",    cont.FechaVencimiento);
                cmd.Parameters.AddWithValue("@Estado",       cont.Estado);
                cmd.Parameters.AddWithValue("@Obs",          cont.Observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idContrato)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Contrato WHERE IdContrato=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", idContrato);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
