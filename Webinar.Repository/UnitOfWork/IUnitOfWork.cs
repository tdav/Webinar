﻿namespace Arch.EntityFrameworkCore.UnitOfWork
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    public interface IUnitOfWork : IDisposable
    {
        void ChangeDatabase(string database);

        IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = false) where TEntity : class;

        int SaveChanges(bool ensureAutoHistory = false);

        Task<int> SaveChangesAsync(bool ensureAutoHistory = false);

        int ExecuteSqlCommand(string sql, params object[] parameters);

        IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : class;

        void TrackGraph(object rootEntity, Action<EntityEntryGraphNode> callback);

        void SetForceMode();
        void DetectChanges();
        void DisableForceMode();
    }
}