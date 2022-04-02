using Challenge.Application.Command;
using Challenge.Application.Queries.ClienteQuerie;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.UI
{
    public class ClienteController : Controller
    {
        private readonly IClienteCommand _clienteCommand;
        private readonly IClienteQueries _clienteQueries;
        public ClienteController(
            IClienteCommand clienteCommand,
            IClienteQueries clienteQueries)
        {
            _clienteCommand = clienteCommand;
            _clienteQueries = clienteQueries;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
