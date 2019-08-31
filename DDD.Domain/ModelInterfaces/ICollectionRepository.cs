using DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ModelInterfaces
{
    public interface ICollectionRepository : IRepository<Collection>
    {
        int GetOrderCollectionNumber(int orderId);

        void MaterialCollection(int orderId, int number);

        BindingList<Collection> GetOrderIdCollectionInfo(int orderId);
    }
}
