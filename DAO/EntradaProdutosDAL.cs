
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAL
{
    public class EntradaProdutosDAL : CRUDIntegridade<EntradaProdutos>
    {
        public int Inserir(EntradaProdutos entradaProdutos)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "INSERT INTO ENTRADAPRODUTOS (USUARIO_ID, DATA_ENTRADA, VALORTOTAL) VALUES (@USUARIO_ID, @DATA_ENTRADA, @VALORTOTAL); select scope_identity()";
            command.Parameters.AddWithValue("@USUARIO_ID", entradaProdutos.usuarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", entradaProdutos.dataEntrada);
            command.Parameters.AddWithValue("@VALORTOTAL", entradaProdutos.valorTotal);
            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException e)
            {
                throw new Exception("erro no acesso ao banco: "+e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private int pegarIdEntrada()
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select SCOPE_IDENTITY()";

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return Convert.ToInt32(reader[""]);
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

        private EntradaProdutos instanciarentradaProdutos(SqlDataReader reader)
        {
            EntradaProdutos entradaProdutos = new EntradaProdutos();
            entradaProdutos.id = Convert.ToInt32(reader["ID"]);
            entradaProdutos.valorTotal = Convert.ToDouble(reader["VALORTOTAL"]);
            entradaProdutos.usuarioId = Convert.ToInt32(reader["USUARIO_ID"]);
            entradaProdutos.dataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"]);

            return entradaProdutos;
        }

        public List<EntradaProdutos> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM ENTRADAPRODUTOS";
            command.Connection = connection;
            List<EntradaProdutos> list = new List<EntradaProdutos>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(instanciarentradaProdutos(reader));
                    }
                    return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("erro no acesso ao banco: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public EntradaProdutos LerPorID(int id)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from entradaProdutos where id= @id";
            command.Parameters.AddWithValue("@id", id);
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
            catch (SqlException ex)
            {
                throw new Exception("erro no acesso ao banco: "+ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        string CRUDIntegridade<EntradaProdutos>.Inserir(EntradaProdutos item)
        {
            throw new NotImplementedException();
        }
    }
}
