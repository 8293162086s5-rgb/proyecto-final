using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ReservaDAO
    {
        public void Agregar(Reserva res)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Reserva (IdVisitante, CantidadPersonas, FechaReserva, Hora, Tipo, Estado, Observaciones)
                                 VALUES (@IdVisitante, @CantidadPersonas, @FechaReserva, @Hora, @Tipo, @Estado, @Observaciones)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVisitante",      res.IdVisitante);
                cmd.Parameters.AddWithValue("@CantidadPersonas", res.CantidadPersonas);
                cmd.Parameters.AddWithValue("@FechaReserva",     res.FechaReserva);
                cmd.Parameters.AddWithValue("@Hora",             res.Hora);
                cmd.Parameters.AddWithValue("@Tipo",             res.Tipo);
                cmd.Parameters.AddWithValue("@Estado",           res.Estado);
                cmd.Parameters.AddWithValue("@Observaciones",    res.Observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Reserva> Listar()
        {
            List<Reserva> lista = new List<Reserva>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT r.IdReserva, r.IdVisitante,
                                        v.Nombre + ' ' + v.Apellido AS NombreVisitante,
                                        r.CantidadPersonas, r.FechaReserva, r.Hora,
                                        r.Tipo, r.Estado, r.Observaciones
                                 FROM Reserva r
                                 INNER JOIN Visitante v ON r.IdVisitante = v.IdVisitante
                                 ORDER BY r.FechaReserva DESC";
                SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Reserva
                    {
                        IdReserva        = Convert.ToInt32(reader["IdReserva"]),
                        IdVisitante      = Convert.ToInt32(reader["IdVisitante"]),
                        NombreVisitante  = reader["NombreVisitante"].ToString(),
                        CantidadPersonas = Convert.ToInt32(reader["CantidadPersonas"]),
                        FechaReserva     = Convert.ToDateTime(reader["FechaReserva"]),
                        Hora             = Convert.ToDateTime(reader["Hora"]),
                        Tipo             = reader["Tipo"].ToString(),
                        Estado           = reader["Estado"].ToString(),
                        Observaciones    = reader["Observaciones"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Reserva res)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Reserva SET IdVisitante=@IdVisitante, CantidadPersonas=@CantidadPersonas,
                                 FechaReserva=@FechaReserva, Hora=@Hora, Tipo=@Tipo, Estado=@Estado, Observaciones=@Observaciones
                                 WHERE IdReserva=@IdReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReserva",        res.IdReserva);
                cmd.Parameters.AddWithValue("@IdVisitante",      res.IdVisitante);
                cmd.Parameters.AddWithValue("@CantidadPersonas", res.CantidadPersonas);
                cmd.Parameters.AddWithValue("@FechaReserva",     res.FechaReserva);
                cmd.Parameters.AddWithValue("@Hora",             res.Hora);
                cmd.Parameters.AddWithValue("@Tipo",             res.Tipo);
                cmd.Parameters.AddWithValue("@Estado",           res.Estado);
                cmd.Parameters.AddWithValue("@Observaciones",    res.Observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idReserva)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reserva WHERE IdReserva=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", idReserva);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
