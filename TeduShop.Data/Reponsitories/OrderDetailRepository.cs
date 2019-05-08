using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IOrderDetailRepository : IReponsitory<OrderDetail>
    {

    }
    public class OrderDetailRepository:ReponsitoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
