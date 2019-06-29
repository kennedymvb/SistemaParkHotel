using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class QuartoDALTeste : IEntityCRUD2<Quarto>
    {
        public DbResponse<int> Atualizar(Quarto item)
        {
            throw new NotImplementedException();
        }

        public DbResponse<int> Excluir(Quarto item)
        {
            throw new NotImplementedException();
        }

        public DbResponse<int> Inserir(Quarto item)
        {
            string stringConexao = StringConexao.GetStringConexao();

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO QUARTOS (VALOR_DIARIA, USUARIO_ID, ESTA_OCUPADO) VALUES (@VALOR_DIARIA, @USUARIO_ID, @ESTA_OCUPADO); select scope_identity()";
            command.Parameters.AddWithValue("@VALOR_DIARIA", item.valorDiaria);
            command.Parameters.AddWithValue("@USUARIO_ID", item.usuarioId);
            command.Parameters.AddWithValue("@ESTA_OCUPADO", item.estaOcupado);

            try
            {
                connection.Open();
                int id = Convert.ToInt32(command.ExecuteScalar());
                DbResponse<int> resposta = new DbResponse<int>()
                {
                    Mensagem = "Cadastrado com sucesso.",
                    Sucesso = true,
                    Dados = id
                };
                return resposta;
            }
            catch (Exception ex)
            {
                DbResponse<int> resposta = new DbResponse<int>()
                {
                    Mensagem = "Erro no cadastro.",
                    Sucesso = false,
                    Exception = ex
                };
                return resposta;
            }
            finally
            {
                connection.Close();
            }
        }

        public DbResponse<Quarto> LerPorID(int id)
        {
            throw new NotImplementedException();
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

        public DbResponse<List<Quarto>> LerTodos()
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
                while (reader.Read())
                {
                    list.Add(instanciarquarto(reader));
                }

                DbResponse<List<Quarto>> resposta =
                    new DbResponse<List<Quarto>>()
                    {
                        Dados = list,
                        Sucesso = true,
                        Mensagem = "Dados encontrados"
                    };
                return resposta;
            }
            catch (SqlException e)
            {
                DbResponse<List<Quarto>> resposta =
                    new DbResponse<List<Quarto>>()
                    {
                        Sucesso = false,
                        Mensagem = "Banco indisponível.",
                        Exception = e
                    };
                return resposta;
            }
            finally
            {
                connection.Close();
            }
        }
    }


    class QuartoBLL2 : IEntityCRUD2<Quarto>
    {
        QuartoDALTeste dal = new QuartoDALTeste();

        public DbResponse<int> Atualizar(Quarto item)
        {
            throw new NotImplementedException();
        }

        public DbResponse<int> Excluir(Quarto item)
        {
            throw new NotImplementedException();
        }

        public DbResponse<int> Inserir(Quarto item)
        {
            //Validar(item);

            //Se tiver tudo certo, chama o DAL
             DbResponse<int> resposta = dal.Inserir(item);
             if(!resposta.Sucesso)
            {
                File.AppendAllText("log.txt",resposta.Mensagem + resposta.Exception.Message + resposta.Exception.StackTrace);
            }
            else
            {
                item.id = resposta.Dados;
            }
            return resposta;
        }

        public DbResponse<Quarto> LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public DbResponse<List<Quarto>> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
