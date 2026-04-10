using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class InventarioDAO
    {
        public void Agregar(Inventario inv)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Inventario (IdEmpleado, Nombre, CodigoInventario, Categoria, Epoca, Material, Ubicacion, ValorEstimado, Estado, FechaIngreso, Descripcion)
                                 VALUES (@IdEmpleado, @Nombre, @CodigoInventario, @Categoria, @Epoca, @Material, @Ubicacion, @ValorEstimado, @Estado, @FechaIngreso, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEmpleado",       inv.IdEmpleado);
                cmd.Parameters.AddWithValue("@Nombre",           inv.Nombre);
                cmd.Parameters.AddWithValue("@CodigoInventario", inv.CodigoInventario);
                cmd.Parameters.AddWithValue("@Categoria",        inv.Categoria);
                cmd.Parameters.AddWithValue("@Epoca",            inv.Epoca        ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Material",         inv.Material     ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Ubicacion",        inv.Ubicacion);
                cmd.Parameters.AddWithValue("@ValorEstimado",    inv.ValorEstimado);
                cmd.Parameters.AddWithValue("@Estado",           inv.Estado);
                cmd.Parameters.AddWithValue("@FechaIngreso",     inv.FechaIngreso);
                cmd.Parameters.AddWithValue("@Descripcion",      inv.Descripcion  ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Inventario> Listar()
        {
            List<Inventario> lista = new List<Inventario>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT i.IdInventario, i.IdEmpleado,
                                        e.Nombre + ' ' + e.Apellido AS NombreEmpleado,
                                        i.Nombre, i.CodigoInventario, i.Categoria, i.Epoca,
                                        i.Material, i.Ubicacion, i.ValorEstimado, i.Estado,
                                        i.FechaIngreso, i.Descripcion
                                 FROM Inventario i
                                 INNER JOIN Empleado e ON i.IdEmpleado = e.IdEmpleado
                                 ORDER BY i.Nombre";
                SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Inventario
                    {
                        IdInventario     = Convert.ToInt32(reader["IdInventario"]),
                        IdEmpleado       = Convert.ToInt32(reader["IdEmpleado"]),
                        NombreEmpleado   = reader["NombreEmpleado"].ToString(),
                        Nombre           = reader["Nombre"].ToString(),
                        CodigoInventario = reader["CodigoInventario"].ToString(),
                        Categoria        = reader["Categoria"].ToString(),
                        Epoca            = reader["Epoca"].ToString(),
                        Material         = reader["Material"].ToString(),
                        Ubicacion        = reader["Ubicacion"].ToString(),
                        ValorEstimado    = Convert.ToDecimal(reader["ValorEstimado"]),
                        Estado           = reader["Estado"].ToString(),
                        FechaIngreso     = Convert.ToDateTime(reader["FechaIngreso"]),
                        Descripcion      = reader["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Inventario inv)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Inventario SET IdEmpleado=@IdEmpleado, Nombre=@Nombre,
                                 CodigoInventario=@CodigoInventario, Categoria=@Categoria, Epoca=@Epoca,
                                 Material=@Material, Ubicacion=@Ubicacion, ValorEstimado=@ValorEstimado,
                                 Estado=@Estado, FechaIngreso=@FechaIngreso, Descripcion=@Descripcion
                                 WHERE IdInventario=@IdInventario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdInventario",     inv.IdInventario);
                cmd.Parameters.AddWithValue("@IdEmpleado",       inv.IdEmpleado);
                cmd.Parameters.AddWithValue("@Nombre",           inv.Nombre);
                cmd.Parameters.AddWithValue("@CodigoInventario", inv.CodigoInventario);
                cmd.Parameters.AddWithValue("@Categoria",        inv.Categoria);
                cmd.Parameters.AddWithValue("@Epoca",            inv.Epoca        ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Material",         inv.Material     ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Ubicacion",        inv.Ubicacion);
                cmd.Parameters.AddWithValue("@ValorEstimado",    inv.ValorEstimado);
                cmd.Parameters.AddWithValue("@Estado",           inv.Estado);
                cmd.Parameters.AddWithValue("@FechaIngreso",     inv.FechaIngreso);
                cmd.Parameters.AddWithValue("@Descripcion",      inv.Descripcion  ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idInventario)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Inventario WHERE IdInventario=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", idInventario);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
