using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class EventoDAO
    {
        public void Agregar(Evento ev)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Evento (IdSala, Nombre, Tipo, Responsable, CapacidadMaxima, FechaInicio, FechaFin, Estado, Descripcion)
                                 VALUES (@IdSala, @Nombre, @Tipo, @Responsable, @CapacidadMaxima, @FechaInicio, @FechaFin, @Estado, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdSala",          ev.IdSala);
                cmd.Parameters.AddWithValue("@Nombre",          ev.Nombre);
                cmd.Parameters.AddWithValue("@Tipo",            ev.Tipo);
                cmd.Parameters.AddWithValue("@Responsable",     ev.Responsable);
                cmd.Parameters.AddWithValue("@CapacidadMaxima", ev.CapacidadMaxima);
                cmd.Parameters.AddWithValue("@FechaInicio",     ev.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",        ev.FechaFin);
                cmd.Parameters.AddWithValue("@Estado",          ev.Estado);
                cmd.Parameters.AddWithValue("@Descripcion",     ev.Descripcion ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Evento> Listar()
        {
            List<Evento> lista = new List<Evento>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT e.IdEvento, e.IdSala,
                                        s.Nombre AS NombreSala,
                                        e.Nombre, e.Tipo, e.Responsable, e.CapacidadMaxima,
                                        e.FechaInicio, e.FechaFin, e.Estado, e.Descripcion
                                 FROM Evento e
                                 INNER JOIN Sala s ON e.IdSala = s.IdSala
                                 ORDER BY e.FechaInicio DESC";
                SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Evento
                    {
                        IdEvento        = Convert.ToInt32(reader["IdEvento"]),
                        IdSala          = Convert.ToInt32(reader["IdSala"]),
                        NombreSala      = reader["NombreSala"].ToString(),
                        Nombre          = reader["Nombre"].ToString(),
                        Tipo            = reader["Tipo"].ToString(),
                        Responsable     = reader["Responsable"].ToString(),
                        CapacidadMaxima = Convert.ToInt32(reader["CapacidadMaxima"]),
                        FechaInicio     = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin        = Convert.ToDateTime(reader["FechaFin"]),
                        Estado          = reader["Estado"].ToString(),
                        Descripcion     = reader["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Evento ev)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Evento SET IdSala=@IdSala, Nombre=@Nombre, Tipo=@Tipo, Responsable=@Responsable,
                                 CapacidadMaxima=@CapacidadMaxima, FechaInicio=@FechaInicio, FechaFin=@FechaFin,
                                 Estado=@Estado, Descripcion=@Descripcion
                                 WHERE IdEvento=@IdEvento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEvento",        ev.IdEvento);
                cmd.Parameters.AddWithValue("@IdSala",          ev.IdSala);
                cmd.Parameters.AddWithValue("@Nombre",          ev.Nombre);
                cmd.Parameters.AddWithValue("@Tipo",            ev.Tipo);
                cmd.Parameters.AddWithValue("@Responsable",     ev.Responsable);
                cmd.Parameters.AddWithValue("@CapacidadMaxima", ev.CapacidadMaxima);
                cmd.Parameters.AddWithValue("@FechaInicio",     ev.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",        ev.FechaFin);
                cmd.Parameters.AddWithValue("@Estado",          ev.Estado);
                cmd.Parameters.AddWithValue("@Descripcion",     ev.Descripcion ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idEvento)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Evento WHERE IdEvento=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", idEvento);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
