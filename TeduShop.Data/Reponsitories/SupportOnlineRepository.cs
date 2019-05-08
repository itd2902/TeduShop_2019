using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
namespace TeduShop.Data.Reponsitories
{
    public interface ISupportOnlineRepository : IReponsitory<SupportOnline>
    {

    }
    public class SupportOnlineRepository:ReponsitoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
