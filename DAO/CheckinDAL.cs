using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAL
{
    public class CheckinDAL : ICheckInProcess
    {
        public string Inserir(Checkin checkin)
        {
            
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;


            command.CommandText = "INSERT INTO USUARIOS (DATA_ENTRADA, DATA_PREVISTA_SAIDA, QUARTO_ID, CLIENTE_ID, ID_RESERVA) VALUES  (@DATA_ENTRADA, @DATA_PREVISTA_SAIDA, @QUARTO_ID, @CLIENTE_ID, @ID_RESERVA)";
            command.Parameters.AddWithValue("@DATA_ENTRADA", checkin.dataEntrada);
            command.Parameters.AddWithValue("@DATA_PREVISTA_SAIDA", checkin.dataPrevistaSaida);
            command.Parameters.AddWithValue("@QUARTO_ID", checkin.quartoId);
            command.Parameters.AddWithValue("@CLIENTE_ID", checkin.clienteId);
            command.Parameters.AddWithValue("@ID_RESERVA", checkin.idReserva);

            return "";
        }

        public Checkin LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Checkins where id= @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarCheckin(reader);
                }
                return null;

            }
            catch (Exception e)
            {
                throw new Exception("erro na leitura do id: " +e.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;



        }

        private Checkin instanciarCheckin(SqlDataReader reader)
        {
            Checkin checkin = new Checkin();
            checkin.id = Convert.ToInt32(reader["ID"]);
            checkin.idReserva = Convert.ToInt32(reader["ID_RESERVA"]);
            checkin.dataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
            checkin.quartoId = Convert.ToInt32(reader["QUARTO_ID"]);
            checkin.clienteId = Convert.ToInt32(reader["CLIENTE_ID"]);
            checkin.dataPrevistaSaida = Convert.ToDateTime(reader["DATA_PREVISTA_SAIDA"]);
            return checkin;
        }

        public List<Checkin> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Checkin> list = new List<Checkin>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    while (reader.Read())
                    {
                        list.Add(instanciarCheckin(reader));
                    }
                    return list;
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
    }
}
