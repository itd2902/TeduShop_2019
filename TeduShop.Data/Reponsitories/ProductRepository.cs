using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IProductRepository:IReponsitory<Product>
    {

    }

    public class ProductRepository:ReponsitoryBase<Product>,IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
