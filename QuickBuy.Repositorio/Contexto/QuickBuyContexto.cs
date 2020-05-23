﻿using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet <Usuario> Usuario{ get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Referencias as Classe de Mapeamento Objeto relacional
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Forma de Pagamento Boleto" },
                new FormaPagamento() { Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de Pagamento Cartão de Crédito" },
                new FormaPagamento() { Id = 3, Nome = "Deposito", Descricao = "Forma de Pagamento Déposito" }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}
