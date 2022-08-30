using MediatR;
using Onion.Architecture.Application.Wrappers;

namespace Onion.Architecture.Application.Features.Client.Commands.CreateClientCommand
{
    public class CreateClientCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }


    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Response<int>>
    {
        public async Task<Response<int>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
