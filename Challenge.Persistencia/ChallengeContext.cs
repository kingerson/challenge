using Challenge.Domain;
using Challenge.Domain.AggregateModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge.Persistencia
{
    public class ChallengeContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "dbo";

        public DbSet<Cliente> Clientes { get; set; }
        private ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options) { }
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await base.SaveChangesAsync();
            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Cliente Aggregate
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            #endregion
        }

        public class ChallengeContextDesignFactory : IDesignTimeDbContextFactory<ChallengeContext>
        {
            public ChallengeContextDesignFactory() { }
            public ChallengeContext CreateDbContext(string[] args)
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("config.json")
                    .Build();

                var optionsBuilder = new DbContextOptionsBuilder<ChallengeContext>()
                    .UseSqlServer(configuration["ChallengeConnectionString"]);

                return new ChallengeContext(optionsBuilder.Options);
            }
        }
    }
}
