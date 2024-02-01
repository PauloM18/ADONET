using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            /* 
             * APP.CONFIG
            string server = ConfigurationManager.AppSettings["provider"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            DbConnection conexao = null;
            string connectionString = "";

            if (ConfigurationManager.AppSettings["provider"].ToString().Equals("MSSQL"))
            {
                connectionString = @"Server=" + server + ";Database=" + database + ";User Id=" + user + ";Password=" + password + ";";
                conexao = new SqlConnection(connectionString);
            }
            else
            {
                connectionString = @"Server="+ server +";Database="+ database +";Uid="+ user +";Pwd="+ password +";";
                conexao = new MySqlConnection(connectionString);
            }
            APP.CONFIG 
            */

            //Conexão SQL SERVE
            //DbConnection conexao = new SqlConnection(@"Server =PAULO-HENRIQUE\SQLEXPRESS;Database=TreinaWeb;User Id=sa;Password=Carauari@2021;");

            //MYSQL
            DbConnection conexao = new MySqlConnection(@"Server=localhost;Database=treinaweb;Uid=root;Pwd=;");
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }
        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
        /* 
         * APP.CONFIG
        public static DbParameter GetParametro(string nome, object valor)
        {
            DbParameter parametro = null;
            if (ConfigurationManager.AppSettings["provider"].ToString().Equals("MSSQL"))
            {
                parametro = new SqlParameter(nome, valor);
            }
            else
            {
                parametro = new MySqlParameter(nome, valor);
            }
            return parametro;
        }
        APP.CONFIG
         */
    }
}
