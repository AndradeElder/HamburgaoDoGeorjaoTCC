using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class ClienteVo : EntidadeBaseVo
    {
        
        public int PedidoId { get; set; }
        public int EnderecoId { get; set; }
        public Guid UserId { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual CarrinhoDeComprasVo CarrinhoDeCompras { get; set; }

        public virtual ICollection<PedidoVo> Pedido { get; set; } = new List<PedidoVo>();
        public virtual ICollection<EnderecoVo> Enderecos { get; set; }

    }
}
