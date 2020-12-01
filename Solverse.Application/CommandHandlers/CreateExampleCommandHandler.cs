using MediatR;
using Solverse.Application.Commands;
using Solverse.Domain.DomainServices;
using System.Threading;
using System.Threading.Tasks;

namespace Solverse.Application.CommandHandlers
{
    public class CreateExampleCommandHandler : IRequestHandler<CreateExampleCommand>
    {
        private readonly ExampleDomainService exampleDomainService;

        public CreateExampleCommandHandler(ExampleDomainService exampleDomainService)
        {
            this.exampleDomainService = exampleDomainService;
        }

        public Task<Unit> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
        {
            exampleDomainService.CreateExample(request.Name);
            return Task.FromResult(Unit.Value);
        }
    }
}