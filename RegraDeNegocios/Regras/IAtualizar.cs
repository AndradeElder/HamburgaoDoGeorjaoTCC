﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraDeNegocios.Regras
{
    public interface IAtualizar<T>
    {
        Task<T> AtualizarAsync(T objeto);
    }
}
