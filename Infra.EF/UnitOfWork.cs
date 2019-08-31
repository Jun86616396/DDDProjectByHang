using System;
using DDD.Domain.Interfaces;
using Infra.EF.Contexts;
   

namespace Infra.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ManageContext _flowContext;

        public UnitOfWork(ManageContext flowContext)
        {
            _flowContext = flowContext;
        }

        public bool SaveChanges()
        {
            var count= _flowContext.SaveChanges() > 0;

           
            return count;
        }


        #region old version  use the same context to create Repository so that can use the same transaction

        //private IUserRepository _userRepository = null;
        //public IUserRepository UserRepository
        //{
        //    get
        //    {
        //        if (_userRepository == null)
        //        {
        //            _userRepository = new UserRepository(_flowContext);
        //        }

        //        return _userRepository;
        //    }
        //}

        //private IOrderRepository _orderRepository = null;
        //public IOrderRepository OrderRepository
        //{
        //    get
        //    {
        //        if (_orderRepository == null)
        //        {
        //            _orderRepository = new OrderRepository(_flowContext);
        //        }

        //        return _orderRepository;
        //    }
        //}


        //private IOrderBoxRepository _orderBoxRepository = null;
        //public IOrderBoxRepository OrderBoxRepository
        //{
        //    get
        //    {
        //        if (_orderBoxRepository == null)
        //        {
        //            _orderBoxRepository = new OrderBoxRepository(_flowContext);
        //        }

        //        return _orderBoxRepository;
        //    }
        //}

        //private IAssembleRepository _assembleRepository = null;
        //public IAssembleRepository AssembleRepository
        //{
        //    get
        //    {
        //        if (_assembleRepository == null)
        //        {
        //            _assembleRepository = new AssembleRepository(_flowContext);
        //        }

        //        return _assembleRepository;
        //    }
        //}

        //private ICollectionRepository _collectionRepository = null;
        //public ICollectionRepository CollectionRepository
        //{
        //    get
        //    {
        //        if (_collectionRepository == null)
        //        {
        //            _collectionRepository = new CollectionRepository(_flowContext);
        //        }

        //        return _collectionRepository;
        //    }
        //}

        //private IDayFinishedRepository _dayFinishedRepository = null;
        //public IDayFinishedRepository DayFinishedRepository
        //{
        //    get
        //    {
        //        if (_dayFinishedRepository == null)
        //        {
        //            _dayFinishedRepository = new DayFinishedRepository(_flowContext);
        //        }

        //        return _dayFinishedRepository;
        //    }
        //}

        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                    _flowContext.Dispose();
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~UnitOfWork()
        // {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
