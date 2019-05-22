using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models.ViewModels
{
    public class PostCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }

        public int ParentId { get; set; }
        public string Desctiption { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool HomeFlag { get; set; }
        public virtual IEnumerable<PostViewModel> Posts { get; set; }
    }
}