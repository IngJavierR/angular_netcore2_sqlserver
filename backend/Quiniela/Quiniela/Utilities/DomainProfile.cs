using AutoMapper;
using Quiniela.Models;
using Quiniela.TO;

namespace Quiniela.Utilities
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<UserDO, UserTO>();
        }
    }
}
