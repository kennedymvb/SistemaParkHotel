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

        

        public string Atualizar(Produto produto)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE PRODUTOS SET ID = @ID, NOME = @NOME, DESCRICAO = @DESCRICAO, PRECO = @PRECO, QTD_ESTOQUE = @QTD_ESTOQUE, USUARIO_ID = @USUARIO_ID";
            command.Parameters.AddWithValue("@ID", produto.id);
            command.Parameters.AddWithValue("@NOME", produto.nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
            command.Parameters.AddWithValue("@PRECO", produto.preco);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.qtd_estoque);
            command.Parameters.AddWithValue("@USUARIO_ID", produto.usuarioId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }

            return "atualizado com sucesso";


        }

        public string Excluir(Produto produto)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from PRODUTOS WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", produto.id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return "excluido com sucesso";
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }
            finally
            {
                connection.Close();
            }
        }

        public string Inserir(Produto produto)
        {


            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO PRODUTOS (NOME, DESCRICAO, PRECO, QTD_ESTOQUE, USUARIO_ID) VALUES (@NOME, @DESCRICAO, @PRECO, @QTD_ESTOQUE, @USUARIO_ID)";
            command.Parameters.AddWithValue("@NOME", produto.nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
            command.Parameters.AddWithValue("@PRECO", produto.preco);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.qtd_estoque);
            command.Parameters.AddWithValue("@USUARIO_ID", produto.usuarioId);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return "erro de conexão com o banco";
            }
            finally
            {
                connection.Close();
            }

            return "inserido com sucesso";
        }

        public Produto LerPorID(int id)
        {

            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM PRODUTOS WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarproduto(reader);
                }
                return null;

            }
            catch (SqlException e)
            {
                return "erro " + e;
            }
            finally
            {
                connection.Close();
            }
            return null;

        }
        private Produto instanciarproduto(SqlDataReader reader)
        {
            Produto produto = new Produto();
            produto.id = Convert.ToInt32(reader["ID"]);
            produto.nome = Convert.ToString(reader["NOME"]);
            produto.descricao = Convert.ToString(reader["DESCRICAO"]);
            produto.preco = Convert.ToDouble(reader["PRECO"]);
            produto.qtd_estoque = Convert.ToInt32(reader["QTD_ESTOQUE"]);
            produto.usuarioId = Convert.ToInt32(reader["USUARIO_ID"]);

            return produto;
        }
        public List<Produto> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Produto> list = new List<Produto>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarproduto(reader));
                    }
                    return list;
                }
                return null;

            }
            catch (SqlException e)
            {
                return "erro" + e;
            }
            finally
            {
                connection.Close();
            }
            return null;

        }
    }


}



