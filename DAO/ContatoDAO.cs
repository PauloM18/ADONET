using _9_ADONET.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ADONET.DAO
{
    public class ContatoDAO
    {
        //DataTable ou DataSet
        public DataTable GetContatos()
        {
            //abriu conexao com banco de dados
            DbConnection conexao = DAOUtils.GetConexao();
            //comando que cria comando na classe 
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT *FROM CONTATOS";
            /*
            DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CONTATOS");
            return ds;
            */
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Excluir(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CONTATOS WHERE ID = @id";
            //SQL SERVE
            //comando.Parameters.Add(new SqlParameter("@id", id));

            //MYSQL
            comando.Parameters.Add(new MySqlParameter("@id", id));

            //APP.CONFIG
            //comando.Parameters.Add(DAOUtils.GetParametro("@id", id));
            //APP.CONFIG

            comando.ExecuteNonQuery();
        }
        public void Inserir(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CONTATOS (NOME, EMAIL, TELEFONE) VALUES (@nome, @email, @telefone)";
            //SQL SERVE
            //comando.Parameters.Add(new SqlParameter("@nome", contato.Nome));
            //comando.Parameters.Add(new SqlParameter("@email", contato.Email));
            //comando.Parameters.Add(new SqlParameter("@telefone", contato.Telefone));

            //MYSQL
            comando.Parameters.Add(new MySqlParameter("@nome", contato.Nome));
            comando.Parameters.Add(new MySqlParameter("@email", contato.Email));
            comando.Parameters.Add(new MySqlParameter("@telefone", contato.Telefone));

            //APP.CONFIG
            //comando.Parameters.Add(DAOUtils.GetParametro("@nome", contato.Nome));
            //comando.Parameters.Add(DAOUtils.GetParametro("@email", contato.Email));
            //comando.Parameters.Add(DAOUtils.GetParametro("@telefone", contato.Telefone));
            //APP.CONFIG
            comando.ExecuteNonQuery();
        }
        public void Atualizar(Contato contato)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CONTATOS SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone WHERE ID = @id";
            //SQL SERVE
            //comando.Parameters.Add(new SqlParameter("@nome", contato.Nome));
            //comando.Parameters.Add(new SqlParameter("@email", contato.Email));
            //comando.Parameters.Add(new SqlParameter("@telefone", contato.Telefone));
            //comando.Parameters.Add(new SqlParameter("@id", contato.Id));

            //MYSQL
            comando.Parameters.Add(new MySqlParameter("@nome", contato.Nome));
            comando.Parameters.Add(new MySqlParameter("@email", contato.Email));
            comando.Parameters.Add(new MySqlParameter("@telefone", contato.Telefone));
            comando.Parameters.Add(new MySqlParameter("@id", contato.Id));

            //APP.CONFIG
            //comando.Parameters.Add(DAOUtils.GetParametro("@nome", contato.Nome));
            //comando.Parameters.Add(DAOUtils.GetParametro("@email", contato.Email));
            //comando.Parameters.Add(DAOUtils.GetParametro("@telefone", contato.Telefone));
            //comando.Parameters.Add(DAOUtils.GetParametro("@id", contato.Id));
            //APP.CONFIG
            comando.ExecuteNonQuery();
        }
        public string ContarUsuarios()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM CONTATOS";
            return comando.ExecuteScalar().ToString();
        }
    }
}
