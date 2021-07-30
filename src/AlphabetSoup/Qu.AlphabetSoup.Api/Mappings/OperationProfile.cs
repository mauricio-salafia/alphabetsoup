using AutoMapper;
using Qu.AlphabetSoup.Contract;
using Qu.AlphabetSoup.Domain.Entities;

namespace Qu.AlphabetSoup.Api.Mappings
{
    public class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<OperationResult, OperationResponse>();
        }
    }
}
