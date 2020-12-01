using MediatR;
using Solverse.Application.Queries;
using Solverse.Domain.Interfaces;
using Solverse.Domain.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Solverse.Application.QueryHandlers
{
    public class ExamplesListQueryHandler : IRequestHandler<ExamplesListQuery, List<Example>>
    {
        private readonly IExamplesRepository examplesRepository;

        public ExamplesListQueryHandler(IExamplesRepository examplesRepository)
        {
            this.examplesRepository = examplesRepository;
        }

        public Task<List<Example>> Handle(ExamplesListQuery request, CancellationToken cancellationToken)
        {
            var examples = examplesRepository.GetList();
            return Task.FromResult(examples);
        }
    }
}