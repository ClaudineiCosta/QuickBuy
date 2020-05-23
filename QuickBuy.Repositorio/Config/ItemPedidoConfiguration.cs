
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(obj => obj.Id);
            builder.
                Property(obj => obj.ProdutoId)
                .IsRequired();
            builder.
                Property(obj => obj.Quantidade)
                .IsRequired();

            builder
                .HasOne(obj => obj.Produto);
        }
    }
}
