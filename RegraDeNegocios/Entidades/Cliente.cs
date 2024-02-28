using RegraDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburgaoDoGeorjao.DAO.ValueObjects;

namespace RegraDeNegocios.Entidades
{
    public class Cliente : EntidadeBase
    {
        public Endereco Endereco { get; set; }
        public Guid UserId { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public ClienteVo ToVo()
        {
            return new ClienteVo { Id = Id, UserId = UserId, Nome = Nome, CPF = CPF, Email = Email, Senha = Senha };
        }
    }
}
