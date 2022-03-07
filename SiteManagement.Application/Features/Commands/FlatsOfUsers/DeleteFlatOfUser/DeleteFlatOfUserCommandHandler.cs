using MediatR;
using Microsoft.Extensions.Logging;
using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Application.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace SiteManagement.Application.Features.Commands.FlatsOfUsers.DeleteFlatOfUser
{
    public class DeleteFlatOfUserCommandHandler : IRequestHandler<DeleteFlatOfUserCommand>
    {
        private readonly IFlatOfUserRepository _FlatOfUserRepository;
        private readonly ILogger<DeleteFlatOfUserCommandHandler> _logger;

        public DeleteFlatOfUserCommandHandler(IFlatOfUserRepository FlatOfUserRepository, ILogger<DeleteFlatOfUserCommandHandler> logger)
        {
            _FlatOfUserRepository = FlatOfUserRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteFlatOfUserCommand request, CancellationToken cancellationToken)
        {
            var FlatOfUserToDelete = await _FlatOfUserRepository.GetByIdAsync(request.Id);
            if (FlatOfUserToDelete == null)
                throw new NotFoundException("Not Found!");

            await _FlatOfUserRepository.RemoveAsync(FlatOfUserToDelete);
            _logger.LogInformation($"FlatOfUser {FlatOfUserToDelete.Id} is successfully deleted.");

            return Unit.Value;
        }
    }
}
