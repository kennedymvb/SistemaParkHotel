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
        

        public string Atualizar(SaidaProdutosDetalhes saidaProdutosDetalhes)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE SAIDAPRODUTOSDETALHES SET CLIENTE_ID = @CLIENTE_ID, PRODUTO = @PRODUTO, FORNECEDOR_ID = @FORNECEDOR_ID, QUANTIDADE = @QUANTIDADE, VALOR_UNITARIO = @VALOR_UNITARIO, ENTRADAPRODUTO_ID = @ENTRADAPRODUTO_ID";
            
            command.Parameters.AddWithValue("@CLIENTE_ID", saidaProdutosDetalhes.idCliente);
            command.Parameters.AddWithValue("@PRODUTO", saidaProdutosDetalhes.idProduto);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", saidaProdutosDetalhes.idFornecedor);
            command.Parameters.AddWithValue("@QUANTIDADE", saidaProdutosDetalhes.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", saidaProdutosDetalhes.Valorunitario);
            command.Parameters.AddWithValue("@ENTRADAPRODUTO_ID", saidaProdutosDetalhes.Valorunitario);

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

        public string Excluir(SaidaProdutosDetalhes saidaProdutosDetalhes)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from SAIDAPRODUTOSDETALHES WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", saidaProdutosDetalhes.id);

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

        public string Inserir(SaidaProdutosDetalhes saidaProdutosDetalhes)
        {
            

            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO SAIDAPRODUTOSDETALHES (CLIENTE_ID, PRODUTO, FORNECEDOR_ID, QUANTIDADE, VALOR_UNITARIO, ENTRADAPRODUTO_ID) VALUES (@CLIENTE_ID, @PRODUTO, @FORNECEDOR_ID, @QUANTIDADE, @VALOR_UNITARIO, @ENTRADAPRODUTO_ID)";
            command.Parameters.AddWithValue("@CLIENTE_ID", saidaProdutosDetalhes.idCliente);
            command.Parameters.AddWithValue("@PRODUTO", saidaProdutosDetalhes.idProduto);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", saidaProdutosDetalhes.idFornecedor);
            command.Parameters.AddWithValue("@QUANTIDADE", saidaProdutosDetalhes.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", saidaProdutosDetalhes.Valorunitario);
            command.Parameters.AddWithValue("@ENTRADAPRODUTO_ID", saidaProdutosDetalhes.od);

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

            string stringConexao = stc.getStringConexao();
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
                return "erro " + e;
            }
            finally
            {
                connection.Close();
            }
            return null;

        }
        private SaidaProdutosDetalhes instanciarsaidaProdutosDetalhes(SqlDataReader reader)
        {
            SaidaProdutosDetalhes saidaProdutosDetalhes = new SaidaProdutosDetalhes();
            saidaProdutosDetalhes.id = Convert.ToInt32(reader["ID"]);
            saidaProdutosDetalhes.idCliente = Convert.ToInt32(reader["CLIENTE_ID"]);
            saidaProdutosDetalhes.idProduto = Convert.ToInt32(reader["PRODUTO"]);
            saidaProdutosDetalhes.idFornecedor = Convert.ToInt32(reader["FORNECEDOR_ID"]);
            saidaProdutosDetalhes.Quantidade = Convert.ToInt32(reader["QUANTIDADE"]);
            saidaProdutosDetalhes.Valorunitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
            saidaProdutosDetalhes.idEntradaProdutos = Convert.ToInt32(reader["ENTRADAPRODUTO_ID"]);

            return saidaProdutosDetalhes;
        }
        public List<SaidaProdutosDetalhes> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
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

