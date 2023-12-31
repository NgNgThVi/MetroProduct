﻿using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Common;
using MetroDelivery.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Infrastructure.Repositories
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
            _metroDeliveryDatabaseContext.Remove(entity);
            await _metroDeliveryDatabaseContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync()
        {
            return await _metroDeliveryDatabaseContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _metroDeliveryDatabaseContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            _metroDeliveryDatabaseContext.Update(entity);
            _metroDeliveryDatabaseContext.Entry(entity).State = EntityState.Modified;
            await _metroDeliveryDatabaseContext.SaveChangesAsync();
        }
    }
}
