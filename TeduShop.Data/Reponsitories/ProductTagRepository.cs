using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IProductTagRepository : IReponsitory<ProductTag>
    {

    }
    public class ProductTagRepository:ReponsitoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
