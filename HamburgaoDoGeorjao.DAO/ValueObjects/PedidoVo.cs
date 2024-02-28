using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class PedidoVo : EntidadeBaseVo
    {
        public PedidoVo()
        {
            DataSolicitacao = DateTime.Now;
        }

        public int ClienteId { get; set; }

        public ClienteVo Cliente { get; set; }

        public int CarrinhoDeComprasId { get; set; }
        public CarrinhoDeComprasVo CarrinhoDeCompras { get; set; }


        public string Descricao { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataPreparacao { get; set; }
        public DateTime? DataSaidaEntrega { get; set; }
        public DateTime? DataFinalizacaoEntrega { get; set; }

        public virtual HamburguerVo Hamburguers { get; set; }
    }
}
