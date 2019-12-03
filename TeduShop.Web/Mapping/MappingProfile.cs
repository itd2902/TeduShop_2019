using AutoMapper;

namespace TeduShop.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMapFromViewModelToEntities();
            CreateMapFromEntitiesToViewModel();
        }
        private void CreateMapFromViewModelToEntities()
        {
            //câu lệnh cho phép bỏ qua các trường mà viewmodel không có
            //CreateMap<SupplierViewModel, Supplier>()
            //    .ForMember(dest => dest.CreatedBy, src => src.Ignore())
            //    .ForMember(dest => dest.CreatedDate, src => src.Ignore())
            //    .ForMember(dest => dest.UpdatedDate, src => src.Ignore());
        }
        private void CreateMapFromEntitiesToViewModel()
        {
            //CreateMap<Supplier, SupplierViewModel>();
        }

    }
}