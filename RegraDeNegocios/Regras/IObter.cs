    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Regras
{
    public interface IObter<T>
    {
        Task<List<T>> ObterTodos();
        Task<List<T>> ObterTodos(int[] id);
        Task<T> Obter(int id);
    }
}