using AutoMapper;
using vegaAPI.Controllers.Resources;
using vegaAPI.Models;

namespace vegaAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResources>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}