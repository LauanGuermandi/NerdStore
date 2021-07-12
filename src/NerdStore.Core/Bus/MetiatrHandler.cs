using MediatR;
using NerdStore.Core.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core.Bus
{
    public class MetiatrHandler : IMetiatrHandler
    {
        private readonly IMediator _mediator;
        public MetiatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
