using MediatR;
using Solverse.Domain.Models;
using System.Collections.Generic;

namespace Solverse.Application.Queries
{
    public class ExamplesListQuery : IRequest<List<Example>>
    {
    }
}