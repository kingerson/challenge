using AutoMapper;
using Challenge.Domain.AggregateModel;
using System;
using System.Collections.Generic;

namespace Challenge.Application.Queries.ClienteQuerie
{
    public class ClienteQueries : IClienteQueries
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteQueries(
            IClienteRepository clienteRepository,
            IMapper mapper
            )
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }
        public IEnumerable<ClienteQueriesModel> Listar()
        {
            var lista = _clienteRepository.Listar();
            IEnumerable<ClienteQueriesModel> listaClientes = _mapper.Map<IEnumerable<ClienteQueriesModel>>(lista);
            return listaClientes;
        }
    }
}
