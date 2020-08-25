﻿using Naylah.Data.Abstractions;
using Naylah.Data.Access;
using Naylah.Data.Extensions;
using Naylah.Domain.Abstractions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Naylah.Data.Services
{
    public abstract class TableDataService<TEntity, TModel, TIdentifier> : DataServiceBase
        where TEntity : class, IEntity<TIdentifier>, IModifiable, IEntityUpdate<TModel>, new()
        where TModel : class, IEntity<TIdentifier>, new()
    {
        protected IRepository<TEntity, TIdentifier> Repository;

        protected virtual Func<IQueryable<TEntity>, IQueryable<TModel>> Projection { get; set; } = 
            (q) => q.Project().To<TModel>();

        protected bool UseSoftDelete { get; set; } = false;

        protected bool NotificationThrowException { get; set; } = false;

        public TableDataService(
           IUnitOfWork _unitOfWork,
           IRepository<TEntity, TIdentifier> repository
           ) : this(_unitOfWork, repository, null)
        {
        }

        public TableDataService(
            IUnitOfWork _unitOfWork,
            IRepository<TEntity, TIdentifier> repository,
            IHandler<Notification> notificationHandler
            ) : base(_unitOfWork, notificationHandler)
        {
            Repository = repository;
            NotificationThrowException = notificationHandler == null;
        }

        protected virtual TModel ToModel(TEntity entity)
        {
            return new TModel() { Id = entity.Id };
        }

        protected virtual TEntity FindBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            return Repository.GetAllAsQueryable(includes).Where(predicate).FirstOrDefault();
        }

        protected virtual TEntity FindById(TIdentifier identifier, params Expression<Func<TEntity, object>>[] includes)
        {
            return FindBy(x => x.Id.Equals(identifier), includes);
        }

        protected virtual bool RaiseNotification(Notification notification)
        {
            if (NotificationThrowException)
            {
                throw new Exception(notification.Key + " - " + notification.Value);
            }
            else
            {
                NotificationsHandler.Handle(notification);
            }

            return true;
        }

        public virtual TModel Create(TModel model)
        {
            var entity = Entity.Create<TEntity>();
            
            entity.UpdateFrom(model, new EntityUpdateOptions(UpsertType.Insert));
            entity.UpdateCreatedAt();

            Repository.Create(entity);

            if (!Commit())
            {
                RaiseNotification(Notification.FromType(GetType(), "Transaction was not commited"));
            }

            return ToModel(entity);
        }

        public virtual TModel Update(TModel model)
        {
            var entity = FindById(model.Id);

            if (entity == null)
            {
                RaiseNotification(Notification.FromType(GetType(), "Entity not found"));
            }

            entity.UpdateFrom(model, new EntityUpdateOptions(UpsertType.Update));
            entity.UpdateUpdateAt();

            Repository.Update(entity);

            if (!Commit())
            {
                RaiseNotification(Notification.FromType(GetType(), "Transaction was not commited"));
            }

            return ToModel(entity);
        }

        public virtual TModel Upsert(TModel model)
        {
            var entity = FindById(model.Id);

            if (entity == null)
            {
                return Create(model);
            }
            else
            {
                return Update(model);
            }
        }

        public virtual TModel GetById(TIdentifier id, params Expression<Func<TEntity, object>>[] includes)
        {
            var entity = FindById(id);

            if (entity == null)
            {
                RaiseNotification(Notification.FromType(GetType(), "Entity not found"));
            }

            return ToModel(entity);
        }

        public virtual TModel Delete(TIdentifier id)
        {
            var entity = Repository.GetById(id);

            if (entity == null)
            {
                RaiseNotification(Notification.FromType(GetType(), "Entity not found"));
            }

            if (!UseSoftDelete)
            {
                Repository.Delete(entity);
            }
            else
            {
                entity.Deleted = true;
                Repository.Update(entity);
            }

            if (!Commit())
            {
                RaiseNotification(Notification.FromType(GetType(), "Transaction was not commited"));
            }

            return ToModel(entity);
        }

        public virtual IQueryable<TModel> GetAll()
        {
            var entityQuery =
                 Repository
                 .GetAllAsQueryable()
                 .Where(x => !x.Deleted)
                 ;

            var projectedQuery = Projection.Invoke(entityQuery);

            return projectedQuery;
        }

    }
}