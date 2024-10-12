using Domain_Models;
using InfraStructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Implementation
{
    public class GenericRepository: IGenericRepository
    {
        private readonly RealEstateContext db;
        

        public GenericRepository(RealEstateContext realEstateContext)
        {
            db = realEstateContext;
        }

        public async Task<List<T>> GetAll<T>() where T : class
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<bool> Create<T>(T entity) where T : class
        {
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
            return true;
        }
                             
        public async Task<bool> Update<T>(T entity) where T : class
        {
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete<T>(T entity) where T : class
        {
            db.Set<T>().Remove(entity);
            await db.SaveChangesAsync();
            return true;
        }
    }
}
