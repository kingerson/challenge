using Challenge.Domain.AggregateModel;
using System;
using System.Threading.Tasks;

namespace Challenge.Application.Command
{
    public class ClienteCommand : IClienteCommand
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteCommand(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }
        public async Task Registrar(Cliente modelo)
        {
            if (await _clienteRepository.ExisteClintePorCorreo(modelo))
                throw new Exception("Cliente registrado con el mismo correo");

            await _clienteRepository.Registrar(modelo);
        }
    }
}
