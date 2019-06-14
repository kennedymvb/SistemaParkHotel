
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata

namespace DAL
{
    public class EntradaProdutosDAL : IEntityCRUD<EntradaProdutos>
    {
        

        public string Atualizar(EntradaProdutos entradaProdutos)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE ENTRADAPRODUTOS SET USUARIO_ID=@USUARIO_ID, DATA_ENTRADA=@DATA_ENTRADA, VALORTOTAL=@VALORTOTAL) VALUES ( , , @VALORTOTAL)";
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

            return "cadastrado com sucesso";
        }

        public string Excluir(EntradaProdutos entradaProdutos)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from ENTRADAPRODUTOS WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", entradaProdutos.id);

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

        public string Inserir(EntradaProdutos entradaProdutos)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (USUARIO_ID, DATA_ENTRADA, VALORTOTAL) VALUES (@USUARIO_ID, @DATA_ENTRADA, @VALORTOTAL)";
            command.Parameters.AddWithValue("@USUARIO_ID", entradaProdutos.usuarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", entradaProdutos.dataEntrada);
            command.Parameters.AddWithValue("@VALORTOTAL", entradaProdutos.valorTotal);

            return "";
        }

        public EntradaProdutos entradaProdutos(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from entradaProdutoss where id= @id";
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

        private EntradaProdutos instanciarentradaProdutos(SqlDataReader reader)
        {
            EntradaProdutos entradaProdutos = new EntradaProdutos();
            entradaProdutos.id = Convert.ToInt32(reader["ID"]);
            entradaProdutos.valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);
            entradaProdutos.usuarioId = Convert.ToInt32(reader["USUARIO_ID"]);
            entradaProdutos.dataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);

            entradaProdutos.email = Convert.ToString(reader["EMAIL"]);
            return entradaProdutos;
        }

        public List<EntradaProdutos> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<EntradaProdutos> list = new List<EntradaProdutos>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarentradaProdutos(reader));
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
