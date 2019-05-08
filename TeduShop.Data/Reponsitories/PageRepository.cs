using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IPageRepository : IReponsitory<Page>
    {

    }
    public class PageRepository:ReponsitoryBase<Page>,IPageRepository
    {
        public PageRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
