using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public interface CRUDIntegridade<T>
    {
        string Inserir(T item);
        List<T> LerTodos();
        T LerPorID(int id);
    }
}
