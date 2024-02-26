using RegraDeNegocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Regras
{
    public interface IHamburguerService :

        IAdicionar<Hamburguer>,
        IAtualizar<Hamburguer>,
        IDeletar<Hamburguer>,
        IObter<Hamburguer>
{

}

}
