using Challenge.Domain;
using Challenge.Domain.AggregateModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.Persistencia.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ChallengeContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public ClienteRepository(ChallengeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Cliente> Listar()
        {
            return _context.Clientes.AsNoTracking();
        }

        public async Task<bool> ExisteClintePorCorreo(Cliente modelo)
        {
            return await _context.Clientes.AnyAsync(m => m.Correo == modelo.Correo);
        }

        public async Task Registrar(Cliente modelo)
        {
            var strategy = _context.Database.CreateExecutionStrategy();

            await strategy.ExecuteAsync(async () =>
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                        await _context.Clientes.AddAsync(modelo);
                        await _context.SaveChangesAsync();
                    }
                    catch (Exception)
                    {
                        transaction.Dispose();
                        return;
                    }
                    transaction.Commit();
                }
            });
        }
    }
}
