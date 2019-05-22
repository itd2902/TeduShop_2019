using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }

        public string Content { get; set; }
        public int CategoryId { get; set; }

        public virtual ProductCategoryViewModel ProductCategory { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public int? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        public IEnumerable<PostTagViewModel> PostTags { get; set; }
    }
}