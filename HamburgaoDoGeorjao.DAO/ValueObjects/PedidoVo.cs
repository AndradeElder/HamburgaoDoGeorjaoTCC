﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    internal class PedidoVo
    {
        public PedidoVo()
        {
            DataSolicitacao = DateTime.Now;
            Hamburguers = new List<HamburguerVo>();
        }
        public string Descricao { get; set; }
        public ClienteVo Cliente { get; set; }
        public List<HamburguerVo> Hamburguers { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataPreparacao { get; set; }
        public DateTime? DataSaidaEntrega { get; set; }
        public DateTime? DataFinalizacaoEntrega { get; set; }
    }
}