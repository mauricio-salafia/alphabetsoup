using AutoMapper;
using Qu.AlphabetSoup.Application.Commands;
using Qu.AlphabetSoup.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qu.AlphabetSoup.Application.Mappings
{
    public class MatrixProfile : Profile
    {
        public MatrixProfile()
        {
            CreateMap<CreateMatrixCommand, MatrixEntity>();
        }
    }
}
