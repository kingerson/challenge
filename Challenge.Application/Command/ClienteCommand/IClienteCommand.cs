using Challenge.Domain.AggregateModel;
using System.Threading.Tasks;

namespace Challenge.Application.Command
{
    public interface IClienteCommand
    {
        Task Registrar(Cliente modelo);
    }
}
