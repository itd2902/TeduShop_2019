using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IManuRepository:IReponsitory<Manu>
    {

    }
    public class ManuRepository:ReponsitoryBase<Manu>, IManuRepository
    {
        public ManuRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
