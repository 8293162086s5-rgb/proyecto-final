using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ReporteDAO
    {
        public void Agregar(Reporte rep)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Reporte
                                 (Titulo, Tipo, FechaGeneracion, GeneradoPor,
                                  PeriodoDesde, PeriodoHasta, Descripcion, Estado)
                                 VALUES (@Titulo, @Tipo, @FechaGen, @GeneradoPor,
                                         @Desde, @Hasta, @Descripcion, @Estado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titulo",      rep.Titulo);
                cmd.Parameters.AddWithValue("@Tipo",        rep.Tipo);
                cmd.Parameters.AddWithValue("@FechaGen",    rep.FechaGeneracion);
                cmd.Parameters.AddWithValue("@GeneradoPor", rep.GeneradoPor);
                cmd.Parameters.AddWithValue("@Desde",       rep.PeriodoDesde);
                cmd.Parameters.AddWithValue("@Hasta",       rep.PeriodoHasta);
                cmd.Parameters.AddWithValue("@Descripcion", rep.Descripcion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado",      rep.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Reporte> Listar()
        {
            List<Reporte> lista = new List<Reporte>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT IdReporte, Titulo, Tipo, FechaGeneracion, GeneradoPor,
                                        PeriodoDesde, PeriodoHasta, Descripcion, Estado
                                 FROM Reporte ORDER BY FechaGeneracion DESC";
                SqlCommand    cmd    = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Reporte
                    {
                        IdReporte        = Convert.ToInt32(reader["IdReporte"]),
                        Titulo           = reader["Titulo"].ToString(),
                        Tipo             = reader["Tipo"].ToString(),
                        FechaGeneracion  = Convert.ToDateTime(reader["FechaGeneracion"]),
                        GeneradoPor      = reader["GeneradoPor"].ToString(),
                        PeriodoDesde     = Convert.ToDateTime(reader["PeriodoDesde"]),
                        PeriodoHasta     = Convert.ToDateTime(reader["PeriodoHasta"]),
                        Descripcion      = reader["Descripcion"].ToString(),
                        Estado           = reader["Estado"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Reporte rep)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Reporte SET
                                 Titulo=@Titulo, Tipo=@Tipo, FechaGeneracion=@FechaGen,
                                 GeneradoPor=@GeneradoPor, PeriodoDesde=@Desde, PeriodoHasta=@Hasta,
                                 Descripcion=@Descripcion, Estado=@Estado
                                 WHERE IdReporte=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id",          rep.IdReporte);
                cmd.Parameters.AddWithValue("@Titulo",      rep.Titulo);
                cmd.Parameters.AddWithValue("@Tipo",        rep.Tipo);
                cmd.Parameters.AddWithValue("@FechaGen",    rep.FechaGeneracion);
                cmd.Parameters.AddWithValue("@GeneradoPor", rep.GeneradoPor);
                cmd.Parameters.AddWithValue("@Desde",       rep.PeriodoDesde);
                cmd.Parameters.AddWithValue("@Hasta",       rep.PeriodoHasta);
                cmd.Parameters.AddWithValue("@Descripcion", rep.Descripcion  ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado",      rep.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idReporte)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string     query = "DELETE FROM Reporte WHERE IdReporte=@Id";
                SqlCommand cmd   = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idReporte);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
