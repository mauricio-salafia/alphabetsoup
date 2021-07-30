using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Qu.AlphabetSoup.Application.Commands;
using Qu.AlphabetSoup.Contract;
using System.Threading.Tasks;

namespace Qu.AlphabetSoup.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    public class AlphabetSoupController : ControllerBase
    {
        private readonly IMediator _meaditor;
        private readonly ILogger<AlphabetSoupController> _logger;
        private readonly IMapper _mapper;

        public AlphabetSoupController(IMediator mediator,
            ILogger<AlphabetSoupController> logger,
            IMapper mapper)
        {
            _meaditor = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatrix(AlphabetRequest request)
        {
            var command = _mapper.Map<CreateMatrixCommand>(request);
            var result = await _meaditor.Send(command);
            var response = _mapper.Map<OperationResponse>(result);
            return Ok(response);
        }
    }
}
