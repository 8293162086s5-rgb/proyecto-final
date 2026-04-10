using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class EntradaDAO
    {
        public void Agregar(Entrada ent)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Entrada (IdVisitante, Tipo, Precio, Cantidad, Fecha, MetodoPago, Observaciones)
                                 VALUES (@IdVisitante, @Tipo, @Precio, @Cantidad, @Fecha, @MetodoPago, @Observaciones)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVisitante",   ent.IdVisitante);
                cmd.Parameters.AddWithValue("@Tipo",          ent.Tipo);
                cmd.Parameters.AddWithValue("@Precio",        ent.Precio);
                cmd.Parameters.AddWithValue("@Cantidad",      ent.Cantidad);
                cmd.Parameters.AddWithValue("@Fecha",         ent.Fecha);
                cmd.Parameters.AddWithValue("@MetodoPago",    ent.MetodoPago);
                cmd.Parameters.AddWithValue("@Observaciones", ent.Observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Entrada> Listar()
        {
            List<Entrada> lista = new List<Entrada>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT e.IdEntrada, e.IdVisitante,
                                        v.Nombre + ' ' + v.Apellido AS NombreVisitante,
                                        e.Tipo, e.Precio, e.Cantidad, e.Fecha, e.MetodoPago, e.Observaciones
                                 FROM Entrada e
                                 INNER JOIN Visitante v ON e.IdVisitante = v.IdVisitante
                                 ORDER BY e.Fecha DESC";
                SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Entrada
                    {
                        IdEntrada       = Convert.ToInt32(reader["IdEntrada"]),
                        IdVisitante     = Convert.ToInt32(reader["IdVisitante"]),
                        NombreVisitante = reader["NombreVisitante"].ToString(),
                        Tipo            = reader["Tipo"].ToString(),
                        Precio          = Convert.ToDecimal(reader["Precio"]),
                        Cantidad        = Convert.ToInt32(reader["Cantidad"]),
                        Fecha           = Convert.ToDateTime(reader["Fecha"]),
                        MetodoPago      = reader["MetodoPago"].ToString(),
                        Observaciones   = reader["Observaciones"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Entrada ent)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Entrada SET IdVisitante=@IdVisitante, Tipo=@Tipo, Precio=@Precio,
                                 Cantidad=@Cantidad, Fecha=@Fecha, MetodoPago=@MetodoPago, Observaciones=@Observaciones
                                 WHERE IdEntrada=@IdEntrada";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEntrada",     ent.IdEntrada);
                cmd.Parameters.AddWithValue("@IdVisitante",   ent.IdVisitante);
                cmd.Parameters.AddWithValue("@Tipo",          ent.Tipo);
                cmd.Parameters.AddWithValue("@Precio",        ent.Precio);
                cmd.Parameters.AddWithValue("@Cantidad",      ent.Cantidad);
                cmd.Parameters.AddWithValue("@Fecha",         ent.Fecha);
                cmd.Parameters.AddWithValue("@MetodoPago",    ent.MetodoPago);
                cmd.Parameters.AddWithValue("@Observaciones", ent.Observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idEntrada)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Entrada WHERE IdEntrada=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", idEntrada);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
