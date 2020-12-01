using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Solverse.Application.Commands
{
    public class CreateExampleCommand : IRequest
    {
        public string Name { get; set; }
    }
}
