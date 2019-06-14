using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public interface IEntityCRUD<T>
    {
        string Inserir(T item);
        string Atualizar(T item);
        string Excluir(T item);
        T LerPorID(int id);
        List<T> LerTodos();
    }

    public interface IEntityCRUD2<T>
    {
        DbResponse<int> Inserir(T item);
        DbResponse<int> Atualizar(T item);
        DbResponse<int> Excluir(T item);
        DbResponse<T> LerPorID(int id);
        DbResponse<List<T>> LerTodos();
    }



    public class DbResponse<T>
    {
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }
        public T Dados { get; set; }
        public Exception Exception { get; set; }
    }
}
