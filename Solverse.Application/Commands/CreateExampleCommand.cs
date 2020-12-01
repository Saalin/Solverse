using MediatR;

namespace Solverse.Application.Commands
{
    public class CreateExampleCommand : IRequest
    {
        public string Name { get; }

        public CreateExampleCommand(string name)
        {
            Name = name;
        }
    }
}
