using System.Collections.Generic;

namespace Challenge.Application.Queries.ClienteQuerie
{
    public interface IClienteQueries
    {
        IEnumerable<ClienteQueriesModel> Listar();
    }
}
