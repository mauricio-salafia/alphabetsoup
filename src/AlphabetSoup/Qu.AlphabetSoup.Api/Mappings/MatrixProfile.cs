using AutoMapper;
using Qu.AlphabetSoup.Application.Commands;
using Qu.AlphabetSoup.Contract;

namespace Qu.AlphabetSoup.Api.Mappings
{
    public class MatrixProfile : Profile
    {
        public MatrixProfile()
        {
            CreateMap<AlphabetRequest, CreateMatrixCommand>()
                .ForMember(dest => dest.Matrix, opt => opt.MapFrom(src => src.Matrix))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
