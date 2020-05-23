using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;


namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(obj => obj.Id);

            //Build utiliza o padrão Fluent
            builder.
                Property(obj => obj.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.
                Property(obj => obj.Descricao)
                .IsRequired()
                .HasMaxLength(500);
            builder.
                Property(obj => obj.Preco)
                .IsRequired();
        }
    }
}
