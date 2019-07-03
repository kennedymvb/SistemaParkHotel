using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAL
{
    public class SaidaProdutosDAL : CRUDIntegridade<SaidaProdutos>
    {
        public string Inserir(SaidaProdutos saida)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO SAIDAPRODUTOS (USUARIO_ID, DATA_SAIDA, VALORTOTAL, ID_PRODUTO) VALUES (@USUARIO_ID, @DATA_SAIDA, @VALORTOTAL,)";
            command.Parameters.AddWithValue("@USUARIO_ID", saida.idUsuarioVendedor);
            command.Parameters.AddWithValue("@DATA_SAIDA", saida.dataSaida);
            command.Parameters.AddWithValue("@VALORTOTAL", saida.valorTotal);

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
            return "dados atualizados com sucesso";
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
                    return instanciarentradaProdutos(reader);
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

        private SaidaProdutos instanciarentradaProdutos(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<SaidaProdutos> LerTodos()
        {

            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SAIDAPRODUTOS";

            command.Connection = connection;
            List<SaidaProdutos> list = new List<SaidaProdutos>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(InstanciarSaidaProdutos(reader));
                }
                return list;
            }
            catch
            {
                throw new Exception("Banco de dados indisponível");
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
    }
}
