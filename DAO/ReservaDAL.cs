using BLL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaDAL : IEntityCRUD<Reserva>
    {
        StringConexao stc = new StringConexao();

        public string Atualizar(Reserva reserva)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE RESERVAS SET ID = @ID, USUARIO_ID = @USUARIO_ID, CLIENTE_ID = @CLIENTE_ID, DATA_PREVISAO_CHEGADA = @DATA_PREVISAO_CHEGADA, DATA_PREVISAO_SAIDA = @DATA_PREVISAO_SAIDA, ID_QUARTO = @ID_QUARTO";
            command.Parameters.AddWithValue("@ID", reserva.id);
            command.Parameters.AddWithValue("@USUARIO_ID", reserva.usuarioId);
            command.Parameters.AddWithValue("@CLIENTE_ID", reserva.clienteId);
            command.Parameters.AddWithValue("@DATA_PREVISAO_CHEGADA", reserva.dataPrevisaoChegada);
            command.Parameters.AddWithValue("@DATA_PREVISAO_SAIDA", reserva.dataPrevisaoSaida);
            command.Parameters.AddWithValue("@ID_QUARTO", reserva.quartoId);

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

        public string Excluir(Reserva reserva)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from RESERVAS WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", reserva.id);

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

        public string Inserir(Reserva reserva)
        {
            StringConexao stc = new StringConexao();

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO RESERVAS (USUARIO_ID, CLIENTE_ID, DATA_PREVISAO_CHEGADA, DATA_PREVISAO_SAIDA, ID_QUARTO) VALUES (@USUARIO_ID, @CLIENTE_ID, @DATA_PREVISAO_CHEGADA, @DATA_PREVISAO_SAIDA, @ID_QUARTO)";
            command.Parameters.AddWithValue("@USUARIO_ID", reserva.usuarioId);
            command.Parameters.AddWithValue("@CLIENTE_ID", reserva.clienteId);
            command.Parameters.AddWithValue("@DATA_PREVISAO_CHEGADA", reserva.dataPrevisaoChegada);
            command.Parameters.AddWithValue("@DATA_PREVISAO_SAIDA", reserva.dataPrevisaoSaida);
            command.Parameters.AddWithValue("@ID_QUARTO", reserva.quartoId);

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

        public reserva LerPorID(int id)
        {

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM RESERVAS WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarreserva(reader);
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
        private reserva instanciarreserva(SqlDataReader reader)
        {
            reserva reserva = new reserva();
            reserva.id = Convert.ToInt32(reader["ID"]);
            reserva.usuarioId = Convert.ToDouble(reader["USUARIO_ID"]);
            reserva.clienteId = Convert.ToInt32(reader["CLIENTE_ID"]);
            reserva.dataPrevisaoChegada = Convert.ToDateTime(reader["DATA_PREVISAO_CHEGADA"]);
            reserva.dataPrevisaoSaida = Convert.ToDateTime(reader["DATA_PREVISAO_SAIDA"]);
            reserva.quartoId = Convert.ToDateTime(reader["ID_QUARTO"]);

            return reserva;
        }
        public List<Reserva> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Reserva> list = new List<Reserva>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarreserva(reader));
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

