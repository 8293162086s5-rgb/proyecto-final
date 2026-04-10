using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class PiezaDAO
    {
        public void Agregar(Pieza p)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO Pieza (Nombre,Descripcion,Epoca,Material,EstadoConservacion,Ubicacion,ValorEstimado,IdSala)
                    VALUES(@Nombre,@Desc,@Epoca,@Material,@Estado,@Ubicacion,@Valor,@IdSala)", conn);
                cmd.Parameters.AddWithValue("@Nombre",   p.Nombre);
                cmd.Parameters.AddWithValue("@Desc",     p.Descripcion        ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Epoca",    p.Epoca              ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Material", p.Material           ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado",   p.EstadoConservacion);
                cmd.Parameters.AddWithValue("@Ubicacion",p.Ubicacion          ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Valor",    p.ValorEstimado);
                cmd.Parameters.AddWithValue("@IdSala",   p.IdSala > 0 ? (object)p.IdSala : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Pieza> Listar()
        {
            var lista = new List<Pieza>();
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var reader = new SqlCommand(@"
                    SELECT p.IdPieza,p.Nombre,p.Descripcion,p.Epoca,p.Material,p.EstadoConservacion,
                           p.Ubicacion,p.ValorEstimado,p.IdSala,ISNULL(s.Nombre,'') AS NombreSala
                    FROM Pieza p
                    LEFT JOIN Sala s ON p.IdSala=s.IdSala
                    ORDER BY p.Nombre", conn).ExecuteReader();
                while (reader.Read())
                    lista.Add(new Pieza {
                        IdPieza            = Convert.ToInt32(reader["IdPieza"]),
                        Nombre             = reader["Nombre"].ToString(),
                        Descripcion        = reader["Descripcion"].ToString(),
                        Epoca              = reader["Epoca"].ToString(),
                        Material           = reader["Material"].ToString(),
                        EstadoConservacion = reader["EstadoConservacion"].ToString(),
                        Ubicacion          = reader["Ubicacion"].ToString(),
                        ValorEstimado      = Convert.ToDecimal(reader["ValorEstimado"]),
                        IdSala             = reader["IdSala"]==DBNull.Value ? 0 : Convert.ToInt32(reader["IdSala"]),
                        NombreSala         = reader["NombreSala"].ToString()
                    });
            }
            return lista;
        }

        public void Actualizar(Pieza p)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand(@"UPDATE Pieza SET Nombre=@Nombre,Descripcion=@Desc,Epoca=@Epoca,
                    Material=@Material,EstadoConservacion=@Estado,Ubicacion=@Ubicacion,ValorEstimado=@Valor,IdSala=@IdSala
                    WHERE IdPieza=@IdPieza", conn);
                cmd.Parameters.AddWithValue("@IdPieza",  p.IdPieza);
                cmd.Parameters.AddWithValue("@Nombre",   p.Nombre);
                cmd.Parameters.AddWithValue("@Desc",     p.Descripcion        ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Epoca",    p.Epoca              ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Material", p.Material           ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado",   p.EstadoConservacion);
                cmd.Parameters.AddWithValue("@Ubicacion",p.Ubicacion          ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Valor",    p.ValorEstimado);
                cmd.Parameters.AddWithValue("@IdSala",   p.IdSala > 0 ? (object)p.IdSala : DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Pieza WHERE IdPieza=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
