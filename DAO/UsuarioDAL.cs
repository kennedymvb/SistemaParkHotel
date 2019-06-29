using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAL
{
    public class UsuarioDAL : IEntityCRUD<Usuario>
    {

        public string Atualizar(Usuario usuario)
        {
            string stringConexao = StringConexao.GetStringConexao();
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
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
	            {
                    return "Usuário deve ser único, contém dados já cadastrados";
	            }
                return "erro no banco de dados, contate o admin";
            }

            return "atualizado com sucesso";


        }

        public Usuario Autenticar(string usuario, string senha)
        {
            string stringConexao = StringConexao.GetStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM USUARIOS WHERE EMAIL = @USUARIO AND SENHA = @SENHA";
            command.Parameters.AddWithValue("@USUARIO", usuario);
            command.Parameters.AddWithValue("@SENHA",senha);
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return instanciarusuario(reader);
                }
                else
                {
                    throw new Exception("Usuário e/ou senha incorretos.");
                }
            }
            catch (SqlException ex)
            {
                File.WriteAllText("log.txt",ex.Message);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
            finally
            {
                connection.Close();
            }
        }

        public string Excluir(Usuario usuario)
        {
            string stringConexao = StringConexao.GetStringConexao();
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
            catch (SqlException ex)
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

            string stringConexao = StringConexao.GetStringConexao();
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
            catch (Exception ex)
            {
               if (ex.Message.Contains("UNIQUE"))
	           {
                    return "Usuário deve ser unico";
	           }
               return "erro no banco de dados, contate o admin";
            }
            finally
            {
                connection.Close();
            }

            return "inserido com sucesso";
        }

        public Usuario LerPorID(int id)
        {

            string stringConexao = StringConexao.GetStringConexao();
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
            catch (SqlException ex)
            {
                throw new Exception("erro no acesso ao banco: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private Usuario instanciarusuario(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.id = Convert.ToInt32(reader["ID"]);
            usuario.nome = Convert.ToString(reader["NOME"]);
            usuario.rg = Convert.ToString(reader["RG"]);
            usuario.cpf = Convert.ToString(reader["CPF"]);
            usuario.endereco = Convert.ToString(reader["ENDERECO"]);
            usuario.telefone = Convert.ToString(reader["TELEFONE"]);
            usuario.email = Convert.ToString(reader["EMAIL"]);
            usuario.senha = Convert.ToString(reader["SENHA"]);
            usuario.isAdmin = Convert.ToBoolean(reader["IS_ADMIN"]);

            return usuario;
        }
        public List<Usuario> LerTodos()
        {
            string stringConexao = StringConexao.GetStringConexao();
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
            catch (SqlException ex)
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

