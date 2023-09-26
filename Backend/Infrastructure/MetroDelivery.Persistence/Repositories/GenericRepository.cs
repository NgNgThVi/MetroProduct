using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Common;
using MetroDelivery.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseAuditableEntity
    {
        protected readonly MetroDeliveryDatabaseContext _metroDeliveryDatabaseContext;
        public GenericRepository(MetroDeliveryDatabaseContext context)
        {
            this._metroDeliveryDatabaseContext = context;
        }
        public async Task CreateAsync(T entity)
        {
            await _metroDeliveryDatabaseContext.AddAsync(entity);
            await _metroDeliveryDatabaseContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            var findIdDelete = await _metroDeliveryDatabaseContext.Set<T>().AsNoTracking().Where(q => q.Id == entity.Id).FirstOrDefaultAsync();
            if (findIdDelete == null || findIdDelete.IsDelete) {
                throw new Exception("Not Found");
            }
            findIdDelete.IsDelete = true;
            _metroDeliveryDatabaseContext.Set<T>().Update(findIdDelete);
            await _metroDeliveryDatabaseContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            return await _metroDeliveryDatabaseContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _metroDeliveryDatabaseContext.Set<T>().AsNoTracking().Where(q => q.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _metroDeliveryDatabaseContext.Update(entity);
            _metroDeliveryDatabaseContext.Entry(entity).State = EntityState.Modified;
            await _metroDeliveryDatabaseContext.SaveChangesAsync();
        }
    }
}
