using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IPostTagRepository : IReponsitory<PostTag>
    {

    }
    public class PostTagRepository:ReponsitoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
