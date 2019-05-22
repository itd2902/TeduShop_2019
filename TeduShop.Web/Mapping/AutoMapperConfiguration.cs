using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models.ViewModels;

namespace TeduShop.Web.Mapping
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMapFromViewModelToEntity();
            CreateMapFromEntityToViewModel();
        }

        private void CreateMapFromViewModelToEntity()
        {
            CreateMap<PostViewModel, Post>();
            CreateMap<PostTagViewModel, PostTag>();
            CreateMap<PostCategoryViewModel, PostCategory>();
            CreateMap<ProductCategoryViewModel, ProductCategory>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<TagViewModel, Tag>();
        }

        private void CreateMapFromEntityToViewModel()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostTag, PostTagViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}