﻿using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class ProductoDB
    {
        string cadena = "server=localhost; user=root; database=factura_LM; password=Shinigam96!;";


        public bool Insertar(Producto producto)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO producto VALUES ");
                sql.Append(" (@Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstadoActivo); ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        comando.Parameters.Add("@EstadoActivo", MySqlDbType.Bit).Value = producto.EstadoActivo;
                        comando.ExecuteNonQuery();
                        inserto = true;

                    }
                }


            }
            catch (System.Exception ex)
            {
            }

            return inserto;

        }

        public bool Editar(Producto producto)
        {
            bool edito = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE producto SET ");
                sql.Append(" Descripcion = @Descripcion, Existencia = @Existencia, Precio = @Precio, Foto = @Foto, EstadoActivo = @EstadoActivo ");
                sql.Append(" WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.Foto;
                        comando.Parameters.Add("@EstadoActivo", MySqlDbType.Bit).Value = producto.EstadoActivo;
                        comando.ExecuteNonQuery();
                        edito = true;

                    }
                }


            }
            catch (System.Exception ex)
            {
            }

            return edito;

        }

        public bool Eliminar(string codigo)
        {
            bool elimino = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM producto ");
                sql.Append(" WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        comando.ExecuteNonQuery();
                        elimino = true;

                    }
                }


            }
            catch (System.Exception ex)
            {
            }

            return elimino;

        }

        public DataTable DevolverProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM producto ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);

                    }
                }

            }
            catch (System.Exception ex)
            {
            }

            return dt;

        }

        public byte[] DevolverFoto(string codigo)
        {
            byte[] foto = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT Foto FROM prodcto WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            foto = (byte[])dr["foto"];
                        }

                    }
                }

            }
            catch (System.Exception ex)
            {

            }
            return foto;
        }

        public Producto DevolverProductoPorCodigo(string codigo)
        {
            Producto producto = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM producto WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            producto = new Producto();

                            producto.Codigo = codigo;
                            producto.Descripcion = dr["Descripcion"].ToString();
                            producto.Existencia = Convert.ToInt32(dr["Existencia"]);
                            producto.Precio = Convert.ToDecimal(dr["Precio"]);
                            producto.EstadoActivo = Convert.ToBoolean(dr["EstadoActivo"]);
                        }

                    }
                }

            }
            catch (System.Exception ex)
            {
            }

            return producto;

        }

    }
}
