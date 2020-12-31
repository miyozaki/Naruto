using AutoMapper;
using Naruto.Entities;
using Naruto.Models;

namespace Naruto.Profiles
{
    public class TierProfile : Profile
    {
        public TierProfile()
        {
            CreateMap<TierInputDto, Tier>();
            CreateMap<Tier, TierOutputDto>();
        }
    }
}