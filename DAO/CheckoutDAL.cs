using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CheckoutDAL
    {
        StringConexao stc = new StringConexao();

        public void Inserir(Checkout checkout)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "INSERT INTO CHECKOUTS (CHECK_IN_ID, VALOR_TOTAL, DATA_SAIDA) VALUES  (@CHECK_IN_ID, @VALOR_TOTAL, @DATA_SAIDA)";
            command.Parameters.AddWithValue("@VALOR_TOTAL", checkout.valorTotal);
            command.Parameters.AddWithValue("@DATA_SAIDA", checkout.dataSaida);
            command.Parameters.AddWithValue("@CHECK_IN_ID", checkout.idCheckin);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("checkout deve ser único, contém dados já cadastrados");
                }
                throw new Exception("erro no banco de dados, contate o admin");
            }
            finally
            {
                connection.Close();
            }
        }

        public Checkout LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from checkouts where id= @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarcheckout(reader);
                }
                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private Checkout instanciarcheckout(SqlDataReader reader)
        {
            Checkout checkout = new Checkout();
            checkout.id = Convert.ToInt32(reader["ID"]);
            checkout.idCheckin = Convert.ToInt32(reader["CHECK_IN_ID"]);
            checkout.valorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);
            checkout.dataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
            return checkout;
        }

        public List<Checkout> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM CHECKOUT";

            command.Connection = connection;
            List<Checkout> list = new List<Checkout>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(instanciarcheckout(reader));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void AtualizarValorTotal(Checkout checkout)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "UPDATE CHECKOUTS SET VALOR_TOTAL=@VALOR_TOTAL WHERE ID=@ID";
            command.Parameters.AddWithValue("@VALOR_TOTAL", checkout.valorTotal);
            command.Parameters.AddWithValue("@ID", checkout.id);
            connection.Open();

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
