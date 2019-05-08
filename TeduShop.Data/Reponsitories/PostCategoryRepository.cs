using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IPostCategoryRepository : IReponsitory<PostCategory>
    {

    }
    public class PostCategoryRepository:ReponsitoryBase<PostCategory>,IPostCategoryRepository
    {
        public PostCategoryRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
