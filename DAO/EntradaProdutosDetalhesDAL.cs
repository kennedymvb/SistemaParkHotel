using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    class EntradaProdutosDetalhesDAL : IEntityCRUD<EntradaProdutosDetalhes>
    {
        public string Atualizar(EntradaProdutosDetalhes item)
        {
            throw new NotImplementedException();
        }

        public string Excluir(EntradaProdutosDetalhes item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(EntradaProdutosDetalhes entradaProdutosDetalhes)
        {
            StringConexao stc = new StringConexao();

            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (FORNECEDOR_ID, QUANTIDADE, VALORUNITARIO) VALUES (@FORNECEDOR_ID, @QUANTIDADE, @VALORUNITARIO)";
            command.Parameters.AddWithValue("@FORNECEDOR_ID", entradaProdutosDetalhes.idFornecedor);
            command.Parameters.AddWithValue(" @QUANTIDADE", entradaProdutosDetalhes.quantidade);
            command.Parameters.AddWithValue("@VALORUNITARIO", entradaProdutosDetalhes.valorUnitario);

            return "";
        }

        public EntradaProdutosDetalhes LerPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntradaProdutosDetalhes> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
