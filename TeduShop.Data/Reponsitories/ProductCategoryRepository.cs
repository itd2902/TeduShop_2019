using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    //add define interface not in IRepository
    public interface IProductCategoryRepository:IReponsitory<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : ReponsitoryBase<ProductCategory>, IProductCategoryRepository
    {
        
        public ProductCategoryRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        {
            
        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(w => w.Alias == alias);
        }

    }
}