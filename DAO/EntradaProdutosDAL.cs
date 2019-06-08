﻿using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    class EntradaProdutosDAL : IEntityCRUD<EntradaProdutos>
    {
        StringConexao stc = new StringConexao();

        public string Atualizar(EntradaProdutos item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Excluir(EntradaProdutos item)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public string Inserir(EntradaProdutos entradaProdutos)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO USUARIOS (USUARIO_ID, DATA_ENTRADA, VALORTOTAL) VALUES (@USUARIO_ID, @DATA_ENTRADA, @VALORTOTAL)";
            command.Parameters.AddWithValue("@USUARIO_ID", entradaProdutos.usuarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", entradaProdutos.data);
            command.Parameters.AddWithValue("@VALORTOTAL", entradaProdutos.valorTotal);

            return "";
        }

        public EntradaProdutos LerPorID(int id)
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }

        public List<EntradaProdutos> LerTodos()
        {
            string stringConexao = stc.getStringConexao();
            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand();
        }
    }
}
