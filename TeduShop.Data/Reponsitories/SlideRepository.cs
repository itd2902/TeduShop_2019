using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public class SlideRepository : ReponsitoryBase<Slide>
    {
        public SlideRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}