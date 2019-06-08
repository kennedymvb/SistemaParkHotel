using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class QuartoDAL : IEntityCRUD<Quarto>
    {
        StringConexao stc = new StringConexao();

        public string Atualizar(Quarto item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(Quarto item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Quarto quarto)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO USUARIOS (ID, VALOR_DIARIA, USUARIO_ID, ESTA_OCUPADO) VALUES (@ID, @VALOR_DIARIA, @USUARIO_ID,@ESTA_OCUPADO )";
            command.Parameters.AddWithValue("@ID", quarto.id);
            command.Parameters.AddWithValue("@VALOR_DIARIA", quarto.valorDiaria);
            command.Parameters.AddWithValue("@USUARIO_ID", quarto.usuarioId);
            command.Parameters.AddWithValue("@ESTA_OCUPADO", quarto.estaOcupado);

            return "";
        }

        public Quarto LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Quarto> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
