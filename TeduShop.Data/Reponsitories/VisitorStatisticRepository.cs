using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public class VisitorStatisticRepository:ReponsitoryBase<VisitorStatistic>
    {
        public VisitorStatisticRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
