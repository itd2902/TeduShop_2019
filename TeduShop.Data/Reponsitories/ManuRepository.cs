using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Reponsitories
{
    public class ManuRepository:ReponsitoryBase<ManuRepository>
    {
        public ManuRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
