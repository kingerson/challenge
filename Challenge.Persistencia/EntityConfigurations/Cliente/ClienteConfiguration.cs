using Challenge.Domain.AggregateModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Persistencia
{
    internal class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente", ChallengeContext.DEFAULT_SCHEMA);
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nombres)
                   .HasMaxLength(250)
                   .IsRequired();

            builder.Property(b => b.Apellidos)
                   .HasMaxLength(250)
                   .IsRequired();

            builder.Property(b => b.Correo)
                  .HasMaxLength(320)
                  .IsRequired();

            builder.Property(b => b.Direccion)
                 .HasMaxLength(800);

            builder.Property(b => b.FechaNacimiento);

            builder.Property(b => b.Activo)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.Property(b => b.FechaRegistro)
              .IsRequired();
        }
    }
}
