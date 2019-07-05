using DAO.ReservaViewModel;
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
        

        public string Atualizar(Reserva reserva)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE RESERVAS SET ID = @ID, USUARIO_ID = @USUARIO_ID, CLIENTE_ID = @CLIENTE_ID, DATA_PREVISAO_CHEGADA = @DATA_PREVISAO_CHEGADA, DATA_PREVISAO_SAIDA = @DATA_PREVISAO_SAIDA, ID_QUARTO = @ID_QUARTO";
            command.Parameters.AddWithValue("@ID", reserva.id);
            command.Parameters.AddWithValue("@USUARIO_ID", reserva.idUsuario);
            command.Parameters.AddWithValue("@CLIENTE_ID", reserva.idCliente);
            command.Parameters.AddWithValue("@DATA_PREVISAO_CHEGADA", reserva.dataPrevisaoChegada);
            command.Parameters.AddWithValue("@DATA_PREVISAO_SAIDA", reserva.dataPrevisaoSaida);
            command.Parameters.AddWithValue("@ID_QUARTO", reserva.idQuarto);

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

            string stringConexao = StringConexao.GetStringConexao();
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
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO RESERVAS (USUARIO_ID, CLIENTE_ID, DATA_PREVISAO_CHEGADA, DATA_PREVISAO_SAIDA, ID_QUARTO) VALUES (@USUARIO_ID, @CLIENTE_ID, @DATA_PREVISAO_CHEGADA, @DATA_PREVISAO_SAIDA, @ID_QUARTO)";
            command.Parameters.AddWithValue("@USUARIO_ID", reserva.idUsuario);
            command.Parameters.AddWithValue("@CLIENTE_ID", reserva.idCliente);
            command.Parameters.AddWithValue("@DATA_PREVISAO_CHEGADA", reserva.dataPrevisaoChegada);
            command.Parameters.AddWithValue("@DATA_PREVISAO_SAIDA", reserva.dataPrevisaoSaida);
            command.Parameters.AddWithValue("@ID_QUARTO", reserva.idQuarto);

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

        public Reserva LerPorID(int id)
        {

            string stringConexao = StringConexao.GetStringConexao();

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
                throw new Exception("erro no acesso ao banco: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private Reserva instanciarreserva(SqlDataReader reader)
        {
            Reserva reserva = new Reserva();
            reserva.id = Convert.ToInt32(reader["ID"]);
            reserva.idUsuario = Convert.ToInt32(reader["USUARIO_ID"]);
            reserva.idCliente = Convert.ToInt32(reader["CLIENTE_ID"]);
            reserva.dataPrevisaoChegada = Convert.ToDateTime(reader["DATA_PREVISAO_CHEGADA"]);
            reserva.dataPrevisaoSaida = Convert.ToDateTime(reader["DATA_PREVISAO_SAIDA"]);
            reserva.idQuarto = Convert.ToInt32(reader["ID_QUARTO"]);

            return reserva;
        }
        public List<Reserva> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM RESERVAS";

            command.Connection = connection;
            List<Reserva> list = new List<Reserva>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                    while (reader.Read())
                    {
                        list.Add(instanciarreserva(reader));
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
        public List<ReservaViewModel> LerReservasViewModel()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText =
                @"SELECT FROM R RESERVA R.ID 'Reserva',
                C.ID 'IdCliente',
                C.Nome 'NomeCliente',
                F.ID 'Funcionario',
                F.Nome 'NomeFuncionario',
                R.Data_ENTRADA 'DataEntrada',
                R.DATA_SAIDA_PREVISTA 'DataSaidaPrevista',
                Q.ID 'NumeroQuarto',
                Q.VALOR_DIARIA 'ValorDiaria',
                Q.Tipo 'Tipo'
                FROM RESERVAS R INNER JOIN CLIENTES C ON
                R.ID_CLIENTES = C.ID
                INNER JOIN FUNCIONARIOS F ON
                F.ID = R.ID_FUNCIONARIO";
            List<ReservaViewModel> listReserva = new List<ReservaViewModel>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReservaViewModel viewModel = new ReservaViewModel();
                    listReserva.Add(instanciarReservaViewModel(reader));
                }
                return listReserva;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private ReservaViewModel instanciarReservaViewModel(SqlDataReader reader)
        {
            string Cliente = reader["NomeCliente"].ToString();
            DateTime DataEntrada = Convert.ToDateTime(reader["DataEntrada"]);
            DateTime DataSaida= Convert.ToDateTime(reader["DataSaidaPrevista"]);
            int id = Convert.ToInt32(reader["IdCliente"]);
            int idFuncionario = Convert.ToInt32(reader["IdFuncionario"]);
            int Quarto = Convert.ToInt32(reader[""]);
            string tipoQuarto = reader["Tipo"].ToString();
            string valor = Convert.ToDouble(reader["ValorDiaria"]).ToString("C2");
            return new ReservaViewModel(id, Cliente, Quarto, tipoQuarto, valor, DataEntrada, DataSaida , idFuncionario);
        }
    }




}

