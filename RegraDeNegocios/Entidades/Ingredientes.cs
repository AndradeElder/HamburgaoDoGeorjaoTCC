using Azure.Identity;
using HamburgaoDoGeorjao.DAO.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Entidades
{
    public class Ingredientes : EntidadeBase
    {
        public string Pao { get; set; }

        public string Carne { get; set; }

        public string Maionese { get; set; }

        public string Alface { get; set; }

        public string Bacon { get; set; }

        public string Cebola { get; set; }

        public string Ovo { get; set; }

        public string Tomate { get; set; }

        public string Queijo { get; set; }

        public string Picles { get; set; }

        public string QueijoCheddar { get; set; }

        public IngredientesVo ToVo()
        {
            return new IngredientesVo { Pao = Pao, Carne = Carne, Maionese = Maionese, Alface = Alface, Bacon = Bacon, Cebola = Cebola, Ovo = Ovo, Tomate = Tomate, Queijo = Queijo, Picles = Picles, QueijoCheddar = QueijoCheddar };
        }
    }
}
