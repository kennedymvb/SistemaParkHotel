using BLL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdmnistradorDAL : IEntityCRUD<Admnistrador>
    {
        StringConexao stc = new StringConexao();


        public string Atualizar(Admnistrador item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Excluir(Admnistrador item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Inserir(Admnistrador admnistrador)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO USUARIOS (ID, NOME, RG, CPF, ENDERECO, TELEFONE, EMAIL, SENHA) VALUES (@ID, @NOME, @RG, @CPF, @ENDERECO, @TELEFONE, @EMAIL, @SENHA)";
            command.Parameters.AddWithValue("@NOME", admnistrador.nome);
            command.Parameters.AddWithValue("@RG", admnistrador.rg);
            command.Parameters.AddWithValue("@CPF", admnistrador.cpf);
            command.Parameters.AddWithValue("@ENDERECO", admnistrador.endereco);
            command.Parameters.AddWithValue("@TELEFONE", admnistrador.telefone);
            command.Parameters.AddWithValue("@EMAIL", admnistrador.email);
            command.Parameters.AddWithValue("@SENHA", admnistrador.senha);
            return "";
        }

        public Admnistrador LerPorID(int id)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public List<Admnistrador> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }
    }
}
