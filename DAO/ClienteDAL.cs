using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class ClientesDAL : IEntityCRUD<Cliente>

    {

        

        public string Atualizar(Cliente cliente)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = "UPDATE CLIENTES SET NOME=@NOME, RG=@RG, CPF=@CPF, TELEFONE_1=@TELEFONE_1, TELEFONE_2=@TELEFONE_2, EMAIL=@EMAIL, USUARIO_ID=@USUARIO_ID)";
            command.Parameters.AddWithValue("@NOME", cliente.nome);
            command.Parameters.AddWithValue("@RG", cliente.rg);
            command.Parameters.AddWithValue("@CPF", cliente.cpf);
            command.Parameters.AddWithValue("@TELEFONE_1", cliente.telefone1);
            command.Parameters.AddWithValue("@TELEFONE_2", cliente.telefone2);
            command.Parameters.AddWithValue("@EMAIL", cliente.email);
            command.Parameters.AddWithValue("@USUARIO_ID", cliente.usuarioID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
	            {
                    return "Cliente deve ser único, contém dados já cadastrados";
	            }
                return "erro no banco de dados, contate o admin";
            }
            finally
            {
                connection.Close();
            }

            return "atualizado com sucesso";
        }

        public string Excluir(Cliente cliente)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from clientes WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", cliente.id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return "erro de conexão com o banco" + ex;
            }
            finally
            {
                connection.Close();
            }
          

            return "cliente excluído";
        }

        public string Inserir(Cliente cliente)
        {

            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "INSERT INTO CLIENTES (NOME, RG, CPF, TELEFONE_1, TELEFONE_2, EMAIL, USUARIO_ID) VALUES (@NOME, @RG, @CPF, @TELEFONE_1, @TELEFONE_2, @EMAIL, @USUARIO_ID)";
            command.Parameters.AddWithValue("@NOME", cliente.nome);
            command.Parameters.AddWithValue("@RG", cliente.rg);
            command.Parameters.AddWithValue("@CPF", cliente.cpf);
            command.Parameters.AddWithValue("@TELEFONE_1", cliente.telefone1);
            command.Parameters.AddWithValue("@TELEFONE_2", cliente.telefone2);
            command.Parameters.AddWithValue("@EMAIL", cliente.email);
            command.Parameters.AddWithValue("@USUARIO_ID", cliente.usuarioID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE")) 
	            {
                    return "Cliente deve ser único, contém dados já cadastrados";
	            }
                return"erro no banco de dados, contate o admin";
            }

            return "cadastrado com sucesso";

        }

        public Cliente LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from clientes where id= @id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarcliente(reader);
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

        private Cliente instanciarcliente(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.id = Convert.ToInt32(reader["ID"]);
            cliente.nome = Convert.ToString(reader["NOME"]);
            cliente.cpf = Convert.ToString(reader["CPF"]);
            cliente.rg = Convert.ToString(reader["RG"]);
            cliente.telefone1 = Convert.ToString(reader["TELEFONE_1"]);
            cliente.telefone2 = Convert.ToString(reader["TELEFONE_2"]);
            cliente.nome = (string)reader["Nome"];
            cliente.email = Convert.ToString(reader["EMAIL"]);
            return cliente;
        }

        public List<Cliente> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Cliente> list = new List<Cliente>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarcliente(reader));
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
