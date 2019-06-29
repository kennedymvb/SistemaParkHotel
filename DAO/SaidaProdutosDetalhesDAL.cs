using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAL
{
    public class SaidaProdutosDetalhesDAL
    {
        string stringConexao = StringConexao.GetStringConexao();
        public string Inserir(SaidaProdutosDetalhes saidaProdutosDetalhes)
        {
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO SAIDAPRODUTOSDETALHES (CLIENTE_ID, PRODUTO, FORNECEDOR_ID, QUANTIDADE, VALOR_UNITARIO, ENTRADAPRODUTO_ID) VALUES (@CLIENTE_ID, @PRODUTO, @FORNECEDOR_ID, @QUANTIDADE, @VALOR_UNITARIO, @ENTRADAPRODUTO_ID)";
            command.Parameters.AddWithValue("@CLIENTE_ID", saidaProdutosDetalhes.idCliente);
            command.Parameters.AddWithValue("@PRODUTO", saidaProdutosDetalhes.idProduto);
            command.Parameters.AddWithValue("@QUANTIDADE", saidaProdutosDetalhes.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", saidaProdutosDetalhes.Valorunitario);
            command.Parameters.AddWithValue("@ENTRADAPRODUTO_ID", saidaProdutosDetalhes.idEntradaProdutos);

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

        public SaidaProdutosDetalhes LerPorID(int id)
        {

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SAIDAPRODUTOSDETALHES WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarsaidaProdutosDetalhes(reader);
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
        private SaidaProdutosDetalhes instanciarsaidaProdutosDetalhes(SqlDataReader reader)
        {
            SaidaProdutosDetalhes saidaProdutosDetalhes = new SaidaProdutosDetalhes();
            saidaProdutosDetalhes.id = Convert.ToInt32(reader["ID"]);
            saidaProdutosDetalhes.idCliente = Convert.ToInt32(reader["CLIENTE_ID"]);
            saidaProdutosDetalhes.idProduto = Convert.ToInt32(reader["PRODUTO"]);
            saidaProdutosDetalhes.Quantidade = Convert.ToInt32(reader["QUANTIDADE"]);
            saidaProdutosDetalhes.Valorunitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
            saidaProdutosDetalhes.idEntradaProdutos = Convert.ToInt32(reader["ENTRADAPRODUTO_ID"]);

            return saidaProdutosDetalhes;
        }
        public List<SaidaProdutosDetalhes> LerTodos()
        {
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<SaidaProdutosDetalhes> list = new List<SaidaProdutosDetalhes>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarsaidaProdutosDetalhes(reader));
                    }
                    return list;
                }
                return null;

            }
            catch (SqlException e)
            {
            }
            finally
            {
                connection.Close();
            }
            return null;

        }
    }




}

