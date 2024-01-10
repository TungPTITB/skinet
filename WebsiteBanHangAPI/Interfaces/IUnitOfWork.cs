﻿using WebsiteBanHangAPI.Entities;

namespace WebsiteBanHangAPI.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Complete();
    }
}
