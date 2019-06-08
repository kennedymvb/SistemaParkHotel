using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Metadata;

namespace DAL
{
    public class FornecedorDAL : IEntityCRUD<Fornecedor>
    {
        StringConexao stc = new StringConexao();

        public string Atualizar(Fornecedor item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Excluir(Fornecedor item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Inserir(Fornecedor fornecedor)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (USUARIO_) VALUES (@ID, @RAZAO_SOCIAL , @CNPJ, @NOME_CONTATO, @TELEFONE, @EMAIL, @USUARIO_ID)";
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.razaoSocial);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.cnpj);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.nomeContato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.email);
            command.Parameters.AddWithValue("@USUARIO_ID", fornecedor.usuarioID);



            command.ExecuteNonQuery();
            return "";
        }

        public Fornecedor LerPorID(int id)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public List<Fornecedor> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }
    }
}
