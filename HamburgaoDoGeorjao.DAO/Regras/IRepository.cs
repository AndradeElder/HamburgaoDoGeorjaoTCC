using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HamburgaoDoGeorjao.DAO.Regras
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);

        void Update(TEntity entity);
        void Delete(TEntity entity);



    }
}

/*
Task<TEntity> ObterRegistro(int ID);
List<TEntity> ObterRegistros();
List<TEntity> ObterRegistros(int ID);
int CriarRegistro(TEntity objetoVo);

Task AtualizarRegistro(TEntity objetoParaAtualizar);

Task DeletarRegistro(int ID);
*/