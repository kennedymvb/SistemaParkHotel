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
    public class SaidaProdutosDAL
    {
        public int Inserir(SaidaProdutos saida)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO SAIDAPRODUTOS (USUARIO_ID, DATA_SAIDA, VALORTOTAL, ID_PRODUTO) VALUES (@USUARIO_ID, @DATA_SAIDA, @VALORTOTAL); select SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@USUARIO_ID", saida.idUsuarioVendedor);
            command.Parameters.AddWithValue("@DATA_SAIDA", saida.dataSaida);
            command.Parameters.AddWithValue("@VALORTOTAL", saida.valorTotal);

            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("dados atualizados com sucesso");
        }

        public SaidaProdutos LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from SAIDAPRODUTOS where id= @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return InstanciarSaidaProdutos(reader);
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

        public void InserirItens(SaidaProdutos saida)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            List<SqlCommand> commands = new List<SqlCommand>();
            for (int i = 0; i < saida.itens.Count; i++)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                commands.Add(command);
            }
            for (int i = 0; i < saida.itens.Count; i++)
            {
                commands[i].CommandText = "INSERT INTO ENTRADAPRODUTOSDETALHES (ENTRADAPRODUTO_ID, PRODUTO_ID, CLIENTE_ID, QUANTIDADE, VALOR_UNITARIO) VALUES (@ENTRADAPRODUTO_ID, @PRODUTO_ID, @CLIENTE_ID, @QUANTIDADE, @VALOR_UNITARIO)";
                commands[i].Parameters.AddWithValue("@ENTRADAPRODUTO_ID", saida.id);
                commands[i].Parameters.AddWithValue("@PRODUTO_ID", saida.itens[i].idProduto);
                commands[i].Parameters.AddWithValue("@CLIENTE_ID", saida.itens[i].idCliente);
                commands[i].Parameters.AddWithValue("@QUANTIDADE", saida.itens[i].quantidade);
                commands[i].Parameters.AddWithValue("@VALOR_UNITARIO", saida.itens[i].valorUnitario);
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

        public List<SaidaViewModel> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT EP.ID 'IDLOTE',
                EP.DATA_ENTRADA 'DATA',
                P.NOME 'PRODUTO',
                EP.VALORTOTAL 'VALOR_LOTE',
                CL.NOME 'NOME_CLIENTE', 
                ED.QUANTIDADE 'QUANTIDADE' ,
                ED.VALOR_UNITARIO 'VALOR_UNITARIO'
                FROM ENTRADAPRODUTOSDETALHES ED
                INNER JOIN ENTRADAPRODUTOS EP ON ED.ENTRADAPRODUTO_ID=EP.ID 
                INNER JOIN PRODUTOS P ON ED.PRODUTO_ID= P.ID 
                INNER JOIN CLIENTES CL ON CL.ID= ED.FORNECEDOR_ID";
            try
            {
                List<SaidaViewModel> list = new List<SaidaViewModel>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(InstanciarSaidaViewModel(reader));
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



        private SaidaProdutos InstanciarSaidaProdutos(SqlDataReader reader)
        {
            SaidaProdutos saidaProdutos = new SaidaProdutos();
            saidaProdutos.id = Convert.ToInt32(reader["ID"]);
            saidaProdutos.valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);
            saidaProdutos.idUsuarioVendedor = Convert.ToInt32(reader["USUARIO_ID"]);
            saidaProdutos.dataSaida = Convert.ToDateTime(reader["DATA_SADA"]);

            return saidaProdutos;
        }

        private SaidaViewModel InstanciarSaidaViewModel(SqlDataReader reader)
        {
            SaidaViewModel saidaProdutos = new SaidaViewModel();
            saidaProdutos.Lote = Convert.ToInt32(reader["IDLOTE"]);
            saidaProdutos.Valor_Lote = Math.Round(Convert.ToDouble(reader["VALOR_LOTE"]), 2).ToString();
            saidaProdutos.Valor_Unitario = Math.Round(Convert.ToDouble(reader["VALOR_UNITARIO"]), 2).ToString();
            saidaProdutos.Data_Entrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
            saidaProdutos.Data_Saida = Convert.ToDateTime(reader["DATA_SAIDA"]);
            saidaProdutos.Cliente = Convert.ToString(reader["NOME_CLIENTE"]);

            return saidaProdutos;
        }
    }
}
