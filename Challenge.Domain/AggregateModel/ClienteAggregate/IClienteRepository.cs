using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.Domain.AggregateModel
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task Registrar(Cliente modelo);
        Task<bool> ExisteClintePorCorreo(Cliente modelo);
        IEnumerable<Cliente> Listar();
    }
}
