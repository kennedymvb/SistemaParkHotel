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
    public class CheckinDAL : ICheckInProcess<Checkin>
    {
        string stringConexao = StringConexao.GetStringConexao();
        public void Inserir(Checkin checkin)
        {
            
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            if (checkin.idReserva > 0)
            {
                command.CommandText = "INSERT INTO CHECKINS (DATA_ENTRADA, DATA_PREVISTA_SAIDA, QUARTO_ID, CLIENTE_ID, ID_RESERVA) VALUES  (@DATA_ENTRADA, @DATA_PREVISTA_SAIDA, @QUARTO_ID, @CLIENTE_ID, @ID_RESERVA)";
                command.Parameters.AddWithValue("@DATA_ENTRADA", checkin.dataEntrada);
                command.Parameters.AddWithValue("@DATA_PREVISTA_SAIDA", checkin.dataPrevistaSaida);
                command.Parameters.AddWithValue("@QUARTO_ID", checkin.quartoId);
                command.Parameters.AddWithValue("@CLIENTE_ID", checkin.clienteId);
                command.Parameters.AddWithValue("@ID_RESERVA", checkin.idReserva);
            }
            else
            {
                command.CommandText = "INSERT INTO CHECKINS (DATA_ENTRADA, DATA_PREVISTA_SAIDA, QUARTO_ID, CLIENTE_ID) VALUES  (@DATA_ENTRADA, @DATA_PREVISTA_SAIDA, @QUARTO_ID, @CLIENTE_ID)";
                command.Parameters.AddWithValue("@DATA_ENTRADA", checkin.dataEntrada);
                command.Parameters.AddWithValue("@DATA_PREVISTA_SAIDA", checkin.dataPrevistaSaida);
                command.Parameters.AddWithValue("@QUARTO_ID", checkin.quartoId);
                command.Parameters.AddWithValue("@CLIENTE_ID", checkin.clienteId);
            }
            

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("erro de chave unica");
                }
                throw new Exception("erro no banco");
            }
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

        }

        private Checkin instanciarCheckin(SqlDataReader reader)
        {
            Checkin checkin = new Checkin();
            checkin.id = Convert.ToInt32(reader["ID"]);
            if (reader["ID_RESERVA"]!=DBNull.Value)
            {
                checkin.idReserva = Convert.ToInt32(reader["ID_RESERVA"]);
            }
            checkin.dataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
            checkin.quartoId = Convert.ToInt32(reader["QUARTO_ID"]);
            checkin.clienteId = Convert.ToInt32(reader["CLIENTE_ID"]);
            checkin.dataPrevistaSaida = Convert.ToDateTime(reader["DATA_PREVISTA_SAIDA"]);
            return checkin;
        }

        public List<CheckinViewModel> LerCheckinViewModel()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT C.ID , C.DATA_ENTRADA, C.DATA_PREVISTA_SAIDA,
            C.QUARTO_ID, C.ID, C.ID_RESERVA, CL.NOME FROM CHECKINS C 
            INNER JOIN CLIENTES CL ON C.CLIENTE_ID= CL.ID
            WHERE C.PENDENTE_CHECKOUT=1 ";

            command.Connection = connection;
            List<CheckinViewModel> list = new List<CheckinViewModel>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(instanciarCheckinViewModel(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private CheckinViewModel instanciarCheckinViewModel(SqlDataReader reader)
        {
            CheckinViewModel checkin = new CheckinViewModel();
            checkin.Id = Convert.ToInt32(reader["ID"]);
            if (reader["ID_RESERVA"] != DBNull.Value)
            {
                checkin.idReserva = Convert.ToInt32(reader["ID_RESERVA"]);
            }
            checkin.DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);
            checkin.quarto = Convert.ToInt32(reader["QUARTO_ID"]);
            checkin.Cliente = Convert.ToString(reader["NOME"]);
            checkin.DataPrevistaSaida = Convert.ToDateTime(reader["DATA_PREVISTA_SAIDA"]);
            return checkin;
        }

        public List<Checkin> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM CHECKIN";

            command.Connection = connection;
            List<Checkin> list = new List<Checkin>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(instanciarCheckin(reader));
                    }
                    return list;

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
