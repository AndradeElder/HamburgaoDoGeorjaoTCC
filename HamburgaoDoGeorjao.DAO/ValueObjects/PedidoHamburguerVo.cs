using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class PedidoHamburguerVo
    {
        public int PedidoId { get; set; }
        public PedidoVo Pedido { get; set; }

        public int HamburguerId { get; set; }
        public HamburguerVo Hamburguer { get; set; }
    }
}
