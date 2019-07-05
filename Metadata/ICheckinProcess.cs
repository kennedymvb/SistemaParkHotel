using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public interface ICheckInProcess<T>
    {
        void Inserir(T checkin);
        List<T> LerTodos();
        T LerPorID(int id);
    }
}
