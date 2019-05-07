using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public class PostRepository:ReponsitoryBase<Post>
    {
        public PostRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
