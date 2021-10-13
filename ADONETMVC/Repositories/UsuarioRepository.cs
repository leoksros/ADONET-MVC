﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ADONETMVC.Models;
using ADONETMVC.Repositories;
using ADONETMVC.DataBase;

namespace ADONETMVC.Repositories
{
    public class UsuarioRepository
    {


        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "select id_usuario, nombre_usuario,nombre,apellido,email,clave from usuarios";

            Connection Connection = new Connection();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.id_usuario = reader.GetInt32(0);
                        usuario.nombre_usuario = reader.GetString(1);
                        usuario.nombre = reader.GetString(2);
                        usuario.apellido = reader.GetString(3);
                        usuario.email = reader.GetString(4);
                        usuario.clave = reader.GetString(5);

                        usuarios.Add(usuario);
                    }
                    reader.Close(); 
                    connection.Close(); //cierra la conexión
                }
                catch (Exception e)
                {
                    throw new Exception("Error en la consulta a la DB");
                }
            }
            return usuarios;
        }

        public void Create()
        {
            string query = "insert into usuarios(nombre_usuario,nombre,apellido,clave,email) " +
                           "values(@nombre_usuario,@nombre,@apellido,@clave,@email)";

            Connection Connection = new Connection();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                //command.Parameters.AddWithValue("@nombre", nombre);
                //command.Parameters.AddWithValue("@apellido", apellido);
                //command.Parameters.AddWithValue("@clave", clave);
                //command.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Error en la consulta a la DB");
                }
            }

        }
    }
}