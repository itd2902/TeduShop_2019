namespace TeduShop.Web.Models.ViewModels
{
    public class PostTagViewModel
    {
        public int PostId { get; set; }

        public virtual PostViewModel Post { get; set; }

        public string TagId { get; set; }

        public virtual TagViewModel Tag { get; set; }
    }
}