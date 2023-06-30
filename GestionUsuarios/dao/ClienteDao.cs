using GestionUsuarios.modelos;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.dao
{
    internal class clientedao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string user = "root";
            string passsword = "";
            string bd = "clientes";

            string cadenaConexion = "Database=" + bd + "; Data Source="
                + servidor + "; User Id=" + user + "; Password=" + passsword
                + "";

            MySqlConnection conexiondb = new MySqlConnection(cadenaConexion);
            conexiondb.Open();
            return conexiondb;
        }

        public List<Cliente> clientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "SELECT * FROM `clientes`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = lectura.GetString("id");
                cliente.Nombre= lectura.GetString("nombre");
                cliente.Telefono= lectura.GetString("telefono");
                cliente.Tarjeta = lectura.GetString("tarjeta");
                lista.Add(cliente);
                 
            }
            comando.Connection.Close();
            return lista;
        }

        public void Agregar(Cliente clientes)
        {
            string consulta = "INSERT INTO `clientes` " +
                "(`id`, `nombre`, `telefono`, `tarjeta`) " +
                "VALUES (NULL,'"+ clientes.Nombre+"', '"+ clientes.Telefono 
                +"', '"+ clientes.Tarjeta +"');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Eliminar(Cliente indice)
        {
            string consulta = "DELETE FROM `clientes` " +
                "WHERE `clientes`.`id` = "+ indice.Id ;
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public void Editar(Cliente indice) 
        {
            string consulta = "UPDATE `clientes`" +
                " SET `nombre` = '"+ indice.Nombre+"'," +
                " `telefono` = '"+ indice.Telefono+"', " +
                "`tarjeta` = '"+ indice.Tarjeta+"' " +
                "WHERE `clientes`.`id` = "+indice.Id+ ";"; 
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}
