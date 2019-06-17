using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Metadata;

namespace DAL
{
    public class FornecedorDAL : IEntityCRUD<Fornecedor>
    {
        

        public string Atualizar(Fornecedor fornecedor)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE FORNECEDORES SET ID = @ID, RAZAO_SOCIAL = @RAZAO_SOCIAL, CNPJ = @CNPJ, NOME_CONTATO = @NOME_CONTATO, TELEFONE = @TELEFONE, EMAIL = @EMAIL, USUARIO_ID = @USUARIO_ID)";
            command.Parameters.AddWithValue("@ID", fornecedor.id);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.razaoSocial);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.cnpj);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.nomeContato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.email);
            command.Parameters.AddWithValue("@USUARIO_ID", fornecedor.usuarioID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
	            {
                    return "Fornecedor deve ser único, contém dados já cadastrados";
	            }
                return "Erro no banco de dados, contate o admin";
            }

            return "atualizado com sucesso";


        }

        public string Excluir(Fornecedor fornecedor)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from FORNECEDORES WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", fornecedor.id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return "excluido com sucesso";
            }
            catch (SqlException ex)
            {
                return "erro de conexão com o banco";
            }
            finally
            {
                connection.Close();
            }
        }

        public string Inserir(Fornecedor fornecedor)
        {
            StringConexao stc = new StringConexao();

            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO FORNECEDORES (RAZAO_SOCIAL, CNPJ, NOME_CONTATO, TELEFONE, EMAIL, USUARIO_ID) VALUES (@RAZAO_SOCIAL, @CNPJ, @NOME_CONTATO, @TELEFONE, @EMAIL, @USUARIO_ID)";
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.razaoSocial);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.cnpj);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.nomeContato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.email);
            command.Parameters.AddWithValue("@USUARIO_ID", fornecedor.usuarioID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (eX.Message.Contains("UNIQUE"))
	            {
                    return "Fornecedor deve ser único, contém dados já cadastrados";
	            }
                return "erro no banco de dados, contate o admin";
            }
            finally
            {
                connection.Close();
            }

            return "inserido com sucesso";
        }

        public Fornecedor LerPorID(int id)
        {

            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM FORNECEDORES WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarFornecedor(reader);
                }
                return null;

            }
            catch (SqlException ex)
            {
                return "erro " + ex;
            }
            finally
            {
                connection.Close();
            }
            return null;

        }
        private Fornecedor instanciarFornecedor(SqlDataReader reader)
        {
            Fornecedor Fornecedor = new Fornecedor();
            Fornecedor.id = Convert.ToInt32(reader["ID"]);
            Fornecedor.razaoSocial = Convert.ToString(reader["RAZAO_SOCIAL"]);
            Fornecedor.cnpj = Convert.ToString(reader["CNPJ"]);
            Fornecedor.nomeContato = Convert.ToString(reader["NOME_CONTATO"]);
            Fornecedor.telefone = Convert.ToString(reader["TELEFONE"]);
            Fornecedor.email = Convert.ToString(reader["EMAIL"]);
            Fornecedor.usuarioID = Convert.ToInt32(reader["USUARIO_ID"]);

            return Fornecedor;
        }
        public List<Fornecedor> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Fornecedor> list = new List<Fornecedor>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarFornecedor(reader));
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
}
