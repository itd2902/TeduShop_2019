using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public class TagRepository:ReponsitoryBase<Tag>

    {
        public TagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
