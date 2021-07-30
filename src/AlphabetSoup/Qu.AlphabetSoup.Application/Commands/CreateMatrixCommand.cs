using MediatR;
using Qu.AlphabetSoup.Domain.Entities;
using System.Collections.Generic;

namespace Qu.AlphabetSoup.Application.Commands
{
    public class CreateMatrixCommand : IRequest<OperationResult>
    {
        public IEnumerable<string> Matrix { get; set; }
    }
}
