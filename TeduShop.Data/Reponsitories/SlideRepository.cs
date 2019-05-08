
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface ISlideRepository : IReponsitory<Slide>
    {

    }
    public class SlideRepository : ReponsitoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}