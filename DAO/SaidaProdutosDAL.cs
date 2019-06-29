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
        public string Inserir(SaidaProdutos item)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (USUARIO_ID, DATA_ENTRADA, VALORTOTAL) VALUES (@USUARIO_ID, @DATA_ENTRADA, @VALORTOTAL)";
            command.Parameters.AddWithValue("@USUARIO_ID", entradaProdutos.usuarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", entradaProdutos.dataEntrada);
            command.Parameters.AddWithValue("@VALORTOTAL", entradaProdutos.valorTotal);
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
            catch ()
            {

            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public List<SaidaProdutos> LerTodos()
        {
            throw new NotImplementedException();
        }

        private SaidaProdutos instanciarentradaProdutos(SqlDataReader reader)
        {
            SaidaProdutos saidaProdutos = new SaidaProdutos();
            saidaProdutos.id = Convert.ToInt32(reader["ID"]);
            saidaProdutos.valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);
            saidaProdutos.idUsuarioVendedor = Convert.ToInt32(reader["USUARIO_ID"]);
            saidaProdutos.data = Convert.ToDateTime(reader["DATA_ENTRADA"]);

            return entradaProdutos;
        }
    }
}
