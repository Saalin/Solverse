using Solverse.Domain.Interfaces;
using Solverse.Domain.Models;
using System.Collections.Generic;

namespace Solverse.Persistence.Repositories
{
    public class ExamplesRepository : IExamplesRepository
    {
        private readonly List<Example> storage;

        public ExamplesRepository()
        {
            storage = new List<Example>();
        }

        public List<Example> GetList()
        {
            return storage;
        }

        public void AddExample(Example example)
        {
            storage.Add(example);
        }
    }
}