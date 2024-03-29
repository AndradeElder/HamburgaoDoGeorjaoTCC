﻿using HamburgaoDoGeorjao.DAO.ValueObjects;
using RegraDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Entidades
{
    public class CarrinhoDeCompras : EntidadeBase
    {
        public Cliente Cliente { get; set; }

        public Pedido Pedido { get; set; }

        public int Quantidade { get; set; }

        public double ValorTotal { get; set; }

        public CarrinhoDeComprasVo ToVo()
        {
            return new CarrinhoDeComprasVo { Id = Id, Quantidade = Quantidade};
        }
    }
}
