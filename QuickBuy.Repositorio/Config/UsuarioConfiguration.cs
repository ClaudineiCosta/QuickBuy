using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(obj => obj.Id);

            //Build utiliza o padrão Fluent
            builder.
                Property(obj => obj.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.
                Property(obj => obj.Senha)
                .IsRequired()
                .HasMaxLength(800);
            builder.
                Property(obj => obj.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.
                Property(obj => obj.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(obj => obj.Pedidos)
                .WithOne(childObj => childObj.Usuario);
   

        }
    }
}
