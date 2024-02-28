using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class CarrinhoDeComprasVo : EntidadeBaseVo
    {
        public virtual ClienteVo Cliente { get; set; }
        public int ClienteId { get; set; }

        public virtual PedidoVo Pedido { get; set; }

        public int PedidoId { get; set; }

        public int Quantidade { get; set; }

        public double ValorTotal { get; set; }

    }
}
