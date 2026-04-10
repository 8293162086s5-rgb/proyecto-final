using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class EmpleadoDAO
    {
        public void Agregar(Empleado emp)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Empleado (Nombre, Apellido, Cargo, FechaIngreso, Telefono, Email, Estado)
                                 VALUES (@Nombre, @Apellido, @Cargo, @FechaIngreso, @Telefono, @Email, @Estado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre",       emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido",     emp.Apellido);
                cmd.Parameters.AddWithValue("@Cargo",        emp.Cargo);
                cmd.Parameters.AddWithValue("@FechaIngreso", emp.FechaIngreso);
                cmd.Parameters.AddWithValue("@Telefono",     emp.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",        emp.Email    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado",       emp.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Empleado> Listar()
        {
            List<Empleado> lista = new List<Empleado>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdEmpleado, Nombre, Apellido, Cargo, FechaIngreso, Telefono, Email, Estado FROM Empleado";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Empleado
                    {
                        IdEmpleado   = Convert.ToInt32(reader["IdEmpleado"]),
                        Nombre       = reader["Nombre"].ToString(),
                        Apellido     = reader["Apellido"].ToString(),
                        Cargo        = reader["Cargo"].ToString(),
                        FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]),
                        Telefono     = reader["Telefono"].ToString(),
                        Email        = reader["Email"].ToString(),
                        Estado       = reader["Estado"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Empleado emp)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Empleado SET Nombre=@Nombre, Apellido=@Apellido, Cargo=@Cargo,
                                 FechaIngreso=@FechaIngreso, Telefono=@Telefono, Email=@Email, Estado=@Estado
                                 WHERE IdEmpleado=@IdEmpleado";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEmpleado",   emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@Nombre",       emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido",     emp.Apellido);
                cmd.Parameters.AddWithValue("@Cargo",        emp.Cargo);
                cmd.Parameters.AddWithValue("@FechaIngreso", emp.FechaIngreso);
                cmd.Parameters.AddWithValue("@Telefono",     emp.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",        emp.Email    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado",       emp.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idEmpleado)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Empleado WHERE IdEmpleado=@IdEmpleado";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
