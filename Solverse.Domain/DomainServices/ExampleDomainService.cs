using Solverse.Domain.Interfaces;
using Solverse.Domain.Models;

namespace Solverse.Domain.DomainServices
{
    public class ExampleDomainService
    {
        private readonly IExamplesRepository examplesRepository;

        public ExampleDomainService(IExamplesRepository examplesRepository)
        {
            this.examplesRepository = examplesRepository;
        }

        public void CreateExample(string name)
        {
            var example = new Example { Name = name };
            examplesRepository.AddExample(example);
        }
    }
}
