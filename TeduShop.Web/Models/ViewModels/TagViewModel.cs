using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models.ViewModels
{
    public class TagViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public IEnumerable<PostTagViewModel> PostTags { get; set; }
    }
}