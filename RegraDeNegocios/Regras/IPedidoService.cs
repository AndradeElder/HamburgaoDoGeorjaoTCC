using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegraDeNegocios.Entidades;


namespace RegraDeNegocios.Regras
{
    public interface IPedidoService :

        IAdicionar<Pedido>,
        IAtualizar<Pedido>,
        IDeletar<Pedido>,
        IObter<Pedido>
    {
        string ObterInformacoesPedidos();
    }
}
