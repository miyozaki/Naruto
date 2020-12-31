using AutoMapper;
using Naruto.Entities;
using Naruto.Models;

namespace Naruto.Profiles
{
    public class ShinobiProfile : Profile
    {
        public ShinobiProfile()
        {
            CreateMap<ShinobiInputDto, Shinobi>();
            CreateMap<Shinobi, ShinobiOutputDto>();
        }
    }
}