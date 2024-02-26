using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class CarrinhoDeComprasVo : EntidadeBaseVo
    {
        public ClienteVo Cliente { get; set; }

        public PedidoVo Pedido { get; set; }

        public int Quantidade { get; set; }
    }
}
