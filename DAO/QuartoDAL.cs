using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAL
{
    public class QuartoDAL : IEntityCRUD<Quarto>
    {
        public string Atualizar(Quarto quarto)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE QUARTOS SET ID = @ID, VALOR_DIARIA = @VALOR_DIARIA, USUARIO_ID = @USUARIO_ID, ESTA_OCUPADO = @ESTA_OCUPADO";
            command.Parameters.AddWithValue("@ID", quarto.id);
            command.Parameters.AddWithValue("@VALOR_DIARIA", quarto.valorDiaria);
            command.Parameters.AddWithValue("@USUARIO_ID", quarto.usuarioId);
            command.Parameters.AddWithValue("@ESTA_OCUPADO", quarto.estaOcupado);

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

        public string Excluir(Quarto quarto)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from QUARTOS WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", quarto.id);

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

        public string Inserir(Quarto quarto)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO QUARTOS (VALOR_DIARIA, USUARIO_ID, ESTA_OCUPADO) VALUES (@VALOR_DIARIA, @USUARIO_ID, @ESTA_OCUPADO)";
            command.Parameters.AddWithValue("@VALOR_DIARIA", quarto.valorDiaria);
            command.Parameters.AddWithValue("@USUARIO_ID", quarto.usuarioId);
            command.Parameters.AddWithValue("@ESTA_OCUPADO", quarto.estaOcupado);

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

        public Quarto LerPorID(int id)
        {

            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM QUARTOS WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarquarto(reader);
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
        private Quarto instanciarquarto(SqlDataReader reader)
        {
            Quarto quarto = new Quarto();
            quarto.id = Convert.ToInt32(reader["ID"]);
            quarto.valorDiaria = Convert.ToDouble(reader["VALOR_DIARIA"]);
            quarto.usuarioId = Convert.ToInt32(reader["USUARIO_ID"]);
            quarto.estaOcupado = Convert.ToBoolean(reader["ESTA_OCUPADO"]);

            return quarto;
        }
        public List<Quarto> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Quarto> list = new List<Quarto>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarquarto(reader));
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

