using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EntradaProdutosDetalhesDAL : CRUDIntegridade<EntradaProdutosDetalhes>
    {

        public string Inserir(EntradaProdutosDetalhes entradaProdutosDetalhes)
        {
            

            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO ENTRADAPRODUTOSDETALHES (ENTRADAPRODUTO, PRODUTO, FORNECEDOR_ID, QUANTIDADE, VALOR_UNITARIO) VALUES (@ENTRADAPRODUTO, @PRODUTO, @FORNECEDOR_ID, @QUANTIDADE, @VALOR_UNITARIO)";
            command.Parameters.AddWithValue("@ENTRADAPRODUTO", entradaProdutosDetalhes.idEntradaProduto);
            command.Parameters.AddWithValue("@PRODUTO", entradaProdutosDetalhes.idProduto);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", entradaProdutosDetalhes.idFornecedor);
            command.Parameters.AddWithValue("@QUANTIDADE", entradaProdutosDetalhes.quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", entradaProdutosDetalhes.valorUnitario);

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

        public EntradaProdutosDetalhes LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM ENTRADAPRODUTOSDETALHES WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarEntradaProdutosDetalhes(reader);
                }
                return null;

            }
            catch (SqlException e)
            {
                throw new Exception("erro no acesso ao banco: "+e.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        private EntradaProdutosDetalhes instanciarEntradaProdutosDetalhes(SqlDataReader reader)
        {
            EntradaProdutosDetalhes entradaProdutosDetalhes = new EntradaProdutosDetalhes();
            entradaProdutosDetalhes.id = Convert.ToInt32(reader["ENTRADAPRODUTO"]);
            entradaProdutosDetalhes.idProduto = Convert.ToInt32(reader["PRODUTO"]);
            entradaProdutosDetalhes.idFornecedor = Convert.ToInt32(reader["FORNECEDOR_ID"]);
            entradaProdutosDetalhes.quantidade = Convert.ToInt32(reader["QUANTIDADE"]);
            entradaProdutosDetalhes.valorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);

            return entradaProdutosDetalhes;
        }

        public List<EntradaProdutosDetalhes> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<EntradaProdutosDetalhes> list = new List<EntradaProdutosDetalhes>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarEntradaProdutosDetalhes(reader));
                    }
                    return list;
                }
                return null;

            }
            catch (SqlException e)
            {
                throw new Exception("erro no acesso ao banco: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }


}

