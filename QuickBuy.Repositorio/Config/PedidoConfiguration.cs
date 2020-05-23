using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;


namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(obj => obj.Id);

            //Build utiliza o padrão Fluent
            builder.
                Property(obj => obj.DataPedido)
                .IsRequired();
            builder.
                Property(obj => obj.DataPrevisaoEntrega)
                .IsRequired();

            builder.
                Property(obj => obj.CEP)
                .IsRequired()
                .HasMaxLength(20);

            builder.
                Property(obj => obj.Estado)
                .IsRequired()
                .HasMaxLength(40);

            builder.
                Property(obj => obj.Cidade)
                .IsRequired()
                .HasMaxLength(40);

            builder.
                Property(obj => obj.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(300);

            builder.
                Property(obj => obj.NumeroCompleto)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .HasMany(obj => obj.ItensPedido)
                .WithOne(childObj => childObj.Pedido);

            builder
                .HasOne(obj => obj.FormaPagamento);
        }
    }
}
