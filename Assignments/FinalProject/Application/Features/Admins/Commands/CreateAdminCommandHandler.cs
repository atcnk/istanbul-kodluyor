using Application.Repositories;
using MediatR;

namespace Application.Features.Admins.Commands
{
    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand, CreateAdminResponse>
    {
        private readonly IAdminRepository _adminRepository;

        public CreateAdminCommandHandler(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<CreateAdminResponse> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
