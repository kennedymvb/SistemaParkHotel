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
    public class ProdutoDAL : IEntityCRUD<Produto>
    {

        StringConexao stc = new StringConexao();


        public string Atualizar(Produto item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Excluir(Produto item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Inserir(Produto produto)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (ID, NOME, DESCRICAO, PRECO, QTD_ESTOQUE, USUARIO_ID) VALUES (@ID, @NOME, @DESCRICAO, @PRECO, @QTD_ESTOQUE, @USUARIO_ID)";
            command.Parameters.AddWithValue("@ID", produto.id);
            command.Parameters.AddWithValue("@NOME", produto.nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
            command.Parameters.AddWithValue("@PRECO", produto.preco);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.qtd_estoque);
            command.Parameters.AddWithValue("@USUARIO_ID", produto.usuarioId);
            
            return "";
        }

        public Produto LerPorID(int id)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public List<Produto> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }
    }
}

