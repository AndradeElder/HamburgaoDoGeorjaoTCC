using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburgaoDoGeorjao.DAO.ValueObjects;

namespace RegraDeNegocios.Entidades
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public EnderecoVo ToVo()
        {
            return new EnderecoVo { Rua = Rua, Bairro = Bairro, Numero = Numero, Complemento = Complemento };
        }
    }   
}
