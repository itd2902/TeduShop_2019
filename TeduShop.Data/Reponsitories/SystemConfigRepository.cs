using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface ISystemConfigRepository : IReponsitory<SystemConfig>
    {

    }
    public class SystemConfigRepository:ReponsitoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
