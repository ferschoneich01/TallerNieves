using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    class Cls_CDOrden
    {
        public List<ClsUsuario> Listar()
        {
            List<ClsUsuario> listaUsuarios = new List<ClsUsuario>();

            using (SqlConnection oConexion = new SqlConnection(ClsConexion.cadena))
            {
                try
                {
                    string query = "SELECT u.idUsuario,r.idRol, r.descripcion,u.clave, u.nombreUsuario,p.cedula,p.nombres,p.apellidos,p.direccion,p.telefono,p.fecha_nacimiento, u.estado FROM Usuarios u INNER JOIN Rol r ON r.idRol = u.idRol INNER JOIN PERSONAS p on u.id_persona = p.id_persona";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaUsuarios.Add(new ClsUsuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                                oRol = new ClsRol()
                                {
                                    IdRol = Convert.ToInt32(dr["idRol"]),
                                    Descripcion = dr["descripcion"].ToString()
                                },
                                NombreUsuario = dr["nombreUsuario"].ToString(),
                                Clave = dr["clave"].ToString(),
                                Cedula = dr["cedula"].ToString(),
                                Nombres = dr["nombres"].ToString(),
                                Apellidos = dr["apellidos"].ToString(),
                                Direccion = dr["direccion"].ToString(),
                                Telefono = dr["telefono"].ToString(),
                                FechaNacimiento = dr["fecha_nacimiento"].ToString(),
                                Estado = Convert.ToByte(dr["estado"].ToString())
                            });
                        }
                    }
                }
                catch
                {
                    listaUsuarios = new List<ClsUsuario>();
                }
            }

            return listaUsuarios;
        }

        public int Registrar(ClsUsuario objUsuario, out string mensaje)
        {
            int idUsuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(ClsConexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("Rol", objUsuario.oRol.IdRol);
                    cmd.Parameters.AddWithValue("NombreUsuario", objUsuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("Clave", objUsuario.Clave);
                    cmd.Parameters.AddWithValue("Cedula", objUsuario.Cedula);
                    cmd.Parameters.AddWithValue("Nombres", objUsuario.Nombres);
                    cmd.Parameters.AddWithValue("Apellidos", objUsuario.Apellidos);
                    cmd.Parameters.AddWithValue("Direccion", objUsuario.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", objUsuario.Telefono);
                    cmd.Parameters.AddWithValue("FechaNac", objUsuario.FechaNacimiento);
                    cmd.Parameters.AddWithValue("Estado", objUsuario.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }

        public void Eliminar(int idUsuario)
        {
            try
            {
                using (SqlConnection oConexion = new SqlConnection(ClsConexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", oConexion);
                    cmd.Parameters.AddWithValue("UsuarioId", idUsuario);
                    cmd.Parameters.AddWithValue("Resultado", 1);
                    cmd.Parameters.AddWithValue("Mensaje", "");

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {
            }


        }
    }
}
