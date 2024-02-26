using RegraDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Regras
{
    public interface IClienteService :
    
        IAdicionar<Cliente>,
        IAtualizar<Cliente>,
        IDeletar<Cliente>,
        IObter<Cliente>
{

}


}
