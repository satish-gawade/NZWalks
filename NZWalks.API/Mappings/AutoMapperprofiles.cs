using AutoMapper;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Mappings
{
    public class AutoMapperprofiles : Profile
    {
        public AutoMapperprofiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegioRequestDto, Region>().ReverseMap();
            CreateMap<AddWalkRequestDto, Walks>().ReverseMap();
            CreateMap<Walks, WalkDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
            CreateMap<UpdateWalkRequestDto, Walks>().ReverseMap();

        }
    }
}
