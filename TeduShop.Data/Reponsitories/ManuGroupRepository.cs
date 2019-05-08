using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IManuGroupRepository : IReponsitory<ManuGroup>
    {

    }
    public class ManuGroupRepository: ReponsitoryBase<ManuGroup>,IManuGroupRepository
    {
        public ManuGroupRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
