using System;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
    public class StorageRepository: BaseRepository<Storage, ManageContext>, IStorageRepository
    {
        public StorageRepository(ManageContext dbContext) : base(dbContext)
        {

        }

       
    }
}