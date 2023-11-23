using entregableNET.DataAccess;
using entregableNET.DTO;
using entregableNET.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace entregableNET.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly ContextDB _contextDB;
        public Repository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public async Task<List<T>> GetAll()
        {
            var entity = await _contextDB.Set<T>().ToListAsync();
            return entity;
        }

        public async Task<bool> Insert(T entity)
        {
            try
            {
                _contextDB.Set<T>().Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                _contextDB.Set<T>().Update(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var entity = await _contextDB.Set<T>().FindAsync(id);
                if (entity == null)
                {
                    return false;
                }

                _contextDB.Set<T>().Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
