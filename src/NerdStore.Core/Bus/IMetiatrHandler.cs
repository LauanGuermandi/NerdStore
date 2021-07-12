using NerdStore.Core.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core.Bus
{
    public interface IMetiatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
