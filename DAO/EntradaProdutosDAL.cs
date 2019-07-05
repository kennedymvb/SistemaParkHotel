
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.ViewModels;
using Metadata;

namespace DAL
{
    public class EntradaProdutosDAL
    {
        public int Inserir(EntradaProdutos entradaProdutos)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "INSERT INTO ENTRADAPRODUTOS (USUARIO_ID, DATA_ENTRADA, VALORTOTAL) VALUES (@USUARIO_ID, @DATA_ENTRADA, @VALORTOTAL); select scope_identity() 'id'";
            command.Parameters.AddWithValue("@USUARIO_ID", entradaProdutos.usuarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", entradaProdutos.dataEntrada);
            command.Parameters.AddWithValue("@VALORTOTAL", entradaProdutos.valorTotal);
            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
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

        public void InserirItens(EntradaProdutos entrada)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            List<SqlCommand> commands = new List<SqlCommand>();
            for (int i = 0; i < entrada.itens.Count; i++)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                commands.Add(command);
            }
            for (int i = 0; i < entrada.itens.Count; i++)
            {
                commands[i].CommandText = "INSERT INTO ENTRADAPRODUTOSDETALHES (ENTRADAPRODUTO_ID, PRODUTO_ID, FORNECEDOR_ID, QUANTIDADE, VALOR_UNITARIO) VALUES (@ENTRADAPRODUTO_ID, @PRODUTO_ID, @FORNECEDOR_ID, @QUANTIDADE, @VALOR_UNITARIO)";
                commands[i].Parameters.AddWithValue("@ENTRADAPRODUTO_ID", entrada.id);
                commands[i].Parameters.AddWithValue("@PRODUTO_ID", entrada.itens[i].idProduto);
                commands[i].Parameters.AddWithValue("@FORNECEDOR_ID", entrada.itens[i].idFornecedor);
                commands[i].Parameters.AddWithValue("@QUANTIDADE", entrada.itens[i].quantidade);
                commands[i].Parameters.AddWithValue("@VALOR_UNITARIO", entrada.itens[i].valorUnitario);

                try
                {
                    connection.Open();
                    commands[i].ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    
        private EntradaProdutosViewModel instanciarentradaProdutosView(SqlDataReader reader)
        {
            EntradaProdutosViewModel entradaProdutos = new EntradaProdutosViewModel();
            entradaProdutos.Data=Convert.ToDateTime(reader["DATA"]);
            entradaProdutos.Lote = Convert.ToInt32(reader["IDLOTE"]);
            entradaProdutos.Produto = Convert.ToString(reader["PRODUTO"]);
            entradaProdutos.Quantidade = Convert.ToInt32(reader["QUANTIDADE"]);
            entradaProdutos.Valor_Lote = Convert.ToDouble(reader["VALOR_LOTE"]).ToString();
            entradaProdutos.Valor_Unitario= Convert.ToDouble(reader["VALOR_UNITARIO"]).ToString();
            entradaProdutos.Fornecedor= Convert.ToString(reader["NOME_FORNECEDOR"]);
            return entradaProdutos;
        }
        private EntradaProdutos instanciarentradaProdutos(SqlDataReader reader)
        {
            EntradaProdutos entradaProdutos = new EntradaProdutos();
            entradaProdutos.id = Convert.ToInt32(reader["ID"]);
            entradaProdutos.valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);
            entradaProdutos.usuarioId = Convert.ToInt32(reader["USUARIO_ID"]);
            entradaProdutos.dataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);

            return entradaProdutos;
        }

        public List<EntradaProdutosViewModel> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT EP.ID 'IDLOTE',
                EP.DATA_ENTRADA 'DATA',
                P.NOME 'PRODUTO',
                EP.VALORTOTAL 'VALOR_LOTE',
                F.RAZAO_SOCIAL 'NOME_FORNECEDOR', 
                ED.QUANTIDADE 'QUANTIDADE' ,
                ED.VALOR_UNITARIO 'VALOR_UNITARIO'
                FROM ENTRADAPRODUTOSDETALHES ED
                INNER JOIN ENTRADAPRODUTOS EP ON ED.ENTRADAPRODUTO_ID=EP.ID 
                INNER JOIN PRODUTOS P ON ED.PRODUTO_ID= P.ID 
                INNER JOIN FORNECEDORES F ON F.ID= ED.FORNECEDOR_ID";
            try
            {
                List<EntradaProdutosViewModel> list = new List<EntradaProdutosViewModel>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(instanciarentradaProdutosView(reader));
                    }
                    return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("erro no acesso ao banco: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public EntradaProdutos LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from entradaProdutos where id= @id";
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarentradaProdutos(reader);
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("erro no acesso ao banco: "+ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
