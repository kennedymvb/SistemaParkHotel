using BLL;
using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Reserva : IEntityCRUD<Reserva>
    {
        StringConexao stc = new StringConexao();


        public string Atualizar(Reserva item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Reserva item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Reserva reserva)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO USUARIOS (ID, CLIENTE_ID, DATA_PREVISAO_CHEGADA, DATA_PREVISAO_SAIDA, ID_QUARTO ) VALUES (@ID, @CLIENTE_ID, @DATA_PREVISAO_CHEGADA, @DATA_PREVISAO_SAIDA, @ID_QUARTO)";
            command.Parameters.AddWithValue("@ID", reserva.);
            command.Parameters.AddWithValue("@NOME", usuario.nome);
            command.Parameters.AddWithValue("@RG", usuario.rg);
            
            return "";
        }

        public Reserva LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
