using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Qu.AlphabetSoup.Application.Interfaces;
using Qu.AlphabetSoup.Core.Entities;
using Qu.AlphabetSoup.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Qu.AlphabetSoup.Application.Commands
{
    public class CreateMatrixCommandHandler : IRequestHandler<CreateMatrixCommand, OperationResult>
    {
        private readonly IMatrixService _matrixService;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateMatrixCommandHandler> _logger;

        public CreateMatrixCommandHandler(IMatrixService matrixService, IMapper mapper, ILogger<CreateMatrixCommandHandler> logger)
        {
            _matrixService = matrixService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<OperationResult> Handle(CreateMatrixCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult { Status = StatusEnum.Success };
            try
            {
                var matrix = _mapper.Map<MatrixEntity>(request);
                await _matrixService.CreateMatrixAsync(matrix.Matrix);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Unexpected error creating the matrix.\r\nError: {ex.Message}\r\n{ex}");
                result.Status = StatusEnum.Error;
                result.Messages = new List<string> { ex.Message };
            }

            return result;
        }
    }
}
