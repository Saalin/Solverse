using Solverse.Domain.Models;
using System.Collections.Generic;

namespace Solverse.Domain.Interfaces
{
    public interface IExamplesRepository
    {
        List<Example> GetList();
        void AddExample(Example example);
    }
}
