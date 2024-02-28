﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.ValueObjects
{
    public class HamburguerVo : EntidadeBaseVo
    {

        public int IngredienteId { get; set; }
        public string TipoDePao { get; set; }
        public double Valor { get; set; }
        public string BurgerBliss { get; set; }
        public string BurgerSupremo { get; set; }
        public string PicanhaParadise { get; set; }
        public string RancheroRodeo { get; set; }
        public string SinfoniaDeCogumelos { get; set; }
        public string FrangoFantastico { get; set; }

        public virtual ICollection<PedidoVo> Pedido { get; set; } = new List<PedidoVo>();
        public virtual ICollection<IngredientesVo> Ingredientes { get; set; } = new List<IngredientesVo>();



    }
}
