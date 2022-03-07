using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.Flats.DeleteFlat
{
    public class DeleteFlatCommandHandler : IRequestHandler<DeleteFlatCommand>
    {
        private readonly IFlatRepository _FlatRepository;
        private readonly ILogger<DeleteFlatCommandHandler> _logger;

        public DeleteFlatCommandHandler(IFlatRepository FlatRepository, ILogger<DeleteFlatCommandHandler> logger)
        {
            _FlatRepository = FlatRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteFlatCommand request, CancellationToken cancellationToken)
        {
            var FlatToDelete = await _FlatRepository.GetByIdAsync(request.Id);
            if (FlatToDelete == null)
                throw new NotFoundException("Not Found!");

            await _FlatRepository.RemoveAsync(FlatToDelete);
            _logger.LogInformation($"Flat {FlatToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}
