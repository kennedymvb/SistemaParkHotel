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
    public class UsuarioDAL : IEntityCRUD<Usuario>
    {
        StringConexao stc = new StringConexao();

        public string Atualizar(Usuario usuario)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE USUARIOS SET ID = @ID, NOME = @NOME, RG = @RG, CPF = @CPF, ENDERECO = @ENDERECO, TELEFONE = @TELEFONE, EMAIL = @EMAIL, SENHA = @SENHA, IS_ADMIN = @IS_ADMIN  ";
            command.Parameters.AddWithValue("@ID", usuario.id);
            command.Parameters.AddWithValue("@NOME", usuario.nome);
            command.Parameters.AddWithValue("@RG", usuario.rg);
            command.Parameters.AddWithValue("@CPF", usuario.cpf);
            command.Parameters.AddWithValue("@ENDERECO", usuario.endereco);
            command.Parameters.AddWithValue("@TELEFONE", usuario.telefone);
            command.Parameters.AddWithValue("@EMAIL", usuario.email);
            command.Parameters.AddWithValue("@SENHA", usuario.senha);
            command.Parameters.AddWithValue("@IS_ADMIN", usuario.isAdmin);

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

        public string Excluir(Usuario usuario)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "delete from USUARIOS WHERE ID= @ID ";
            command.Parameters.AddWithValue("@ID", usuario.id);

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

        public string Inserir(Usuario usuario)
        {
            StringConexao stc = new StringConexao();

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (NOME, RG, CPF, ENDERECO, TELEFONE, EMAIL, SENHA, IS_ADMIN ) VALUES (@NOME, @RG, @CPF, @ENDERECO, @TELEFONE, @EMAIL, @SENHA, @IS_ADMIN)";
            command.Parameters.AddWithValue("@NOME", usuario.nome);
            command.Parameters.AddWithValue("@RG", usuario.rg);
            command.Parameters.AddWithValue("@CPF", usuario.cpf);
            command.Parameters.AddWithValue("@ENDERECO", usuario.endereco);
            command.Parameters.AddWithValue("@TELEFONE", usuario.telefone);
            command.Parameters.AddWithValue("@EMAIL", usuario.email);
            command.Parameters.AddWithValue("@SENHA", usuario.senha);
            command.Parameters.AddWithValue("@IS_ADMIN", usuario.isAdmin);

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

        public usuario LerPorID(int id)
        {

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM USUARIOS WHERE ID= @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarusuario(reader);
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
        private usuario instanciarusuario(SqlDataReader reader)
        {
            usuario usuario = new usuario();
            usuario.id = Convert.ToInt32(reader["ID"]);
            usuario.nome = Convert.ToDouble(reader["NOME"]);
            usuario.rg = Convert.ToInt32(reader["RG"]);
            usuario.cpf = Convert.ToDateTime(reader["CPF"]);
            usuario.endereco = Convert.ToDateTime(reader["ENDERECO"]);
            usuario.telefone = Convert.ToDateTime(reader["TELEFONE"]);
            usuario.email = Convert.ToDateTime(reader["EMAIL"]);
            usuario.senha = Convert.ToDateTime(reader["SENHA"]);
            usuario.isAdmin = Convert.ToDateTime(reader["IS_ADMIN"]);

            return usuario;
        }
        public List<Usuario> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            List<Usuario> list = new List<Usuario>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        list.Add(instanciarusuario(reader));
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

