using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(obj => obj.Id);
            builder.
                Property(obj => obj.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.
                Property(obj => obj.Descricao)
                .IsRequired()
                .HasMaxLength(500);

        }
    }
}
