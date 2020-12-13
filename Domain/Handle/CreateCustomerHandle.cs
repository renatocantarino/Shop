using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Response;


namespace Shop.Domain.Handle
{
    public class CreateCustomerHandle : IRequestHandler<CreateCustomerRequest ,CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var retorno = new CreateCustomerResponse { Sucess = true, ReturnObj = request };
            return Task.FromResult(retorno);

        }
    }
}