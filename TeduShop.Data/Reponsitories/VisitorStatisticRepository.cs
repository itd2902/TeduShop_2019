using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IVisitorStatisticRepository : IReponsitory<VisitorStatistic>
    {

    }
    public class VisitorStatisticRepository:ReponsitoryBase<VisitorStatistic>,IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
