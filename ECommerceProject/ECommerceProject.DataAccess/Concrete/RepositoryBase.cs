using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.DataAccess.Concrete.EntityFramework;
using ECommerceProject.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Concrete
{
    public class RepositoryBase<T,TContext> : IRepositoryBase<T> where T : class, IEntity,new() where TContext : DbContext, new()
    {
        private readonly TContext _context;
        public async Task Add(T entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(T entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
             => await _context.Set<T>().FirstOrDefaultAsync(filter);

        //using (var context = new TContext())
        //{
        //    return await context.Set<T>().SingleOrDefaultAsync(filter);
        //}


        public async Task<List<T>> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? await context.Set<T>().ToListAsync()
                    : await context.Set<T>().Where(filter).ToListAsync();
            }
        }

        public async Task Update(T entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
