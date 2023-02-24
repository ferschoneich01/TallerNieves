using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class Cls_CDUsuarios
    {
        public List<ClsUsuarios> Listar()
        {
            List<ClsUsuarios> listaUsuarios = new List<ClsUsuarios>();

            using (SqlConnection oConexion = new SqlConnection(ClsConexion.cadena))
            {
                try
                {
                    string query = "SELECT *, pid.descripcion as Identificacion, r.descripcion as rol FROM Usuarios u INNER JOIN ROLES r ON r.idRol = u.idRol  INNER JOIN PERSONAS p on u.idPersona = p.idPersona INNER JOIN PERSONA_IDENTIFICACION pid on p.idPersonaIdentificacion = pid.idPersonaIdentificacion";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaUsuarios.Add(new ClsUsuarios()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                nombreUsuario = dr["nombreUsuario"].ToString(),
                                claveUsuario = dr["claveUsuario"].ToString(),
                                
                                idRol = Convert.ToInt32(dr["idRol"]),
                         
                                idPersona = Convert.ToInt32(dr["idPersona"].ToString()),
                                idEstadoUsuario = Convert.ToByte(dr["idEstadoUsuario"].ToString())

                            });
                        }
                    }
                }
                catch
                {
                    listaUsuarios = new List<ClsUsuarios>();
                }
            }

            return listaUsuarios;
        }

        public int Registrar(ClsUsuarios objUsuario, out string mensaje)
        {
            int idUsuarioGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(ClsConexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oConexion);
                   /* cmd.Parameters.AddWithValue("Rol", objUsuario.oRol.IdRol);
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
                    cmd.CommandType = CommandType.StoredProcedure;*/

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
