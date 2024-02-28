﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class EnderecoVo : EntidadeBaseVo
    {
        public int ClienteId { get; set; }
        public ClienteVo Cliente { get; set; }
        

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

    }
}
