﻿using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=factura_LM; password=Shinigam96!;";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT* FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstadoActivo"]);
                            user.Foto = (byte[])dr["Foto"];


                        }
                    }
                }


            }
            catch (System.Exception ex)
            {

            }

            return user;

        }

    }
}
