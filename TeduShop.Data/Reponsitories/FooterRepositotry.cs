using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IFooterRepositotry : IReponsitory<Footer>
    {

    }
    public class FooterRepositotry : ReponsitoryBase<Footer>, IFooterRepositotry
    {
        public FooterRepositotry(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
