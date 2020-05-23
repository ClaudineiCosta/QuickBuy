using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : ObjetoGenerico
    {
        public virtual DateTime DataPedido { get; set; }
        
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual DateTime DataPrevisaoEntrega { get; set; }
        public virtual string CEP { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string EnderecoCompleto { get; set; }
        public virtual string NumeroCompleto { get; set; }
        public virtual int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        /// <summary>
        ///Pedido deve ter pelo menos um item ou muito itens de pedido 
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (ItensPedido.Any()) 
            {
                AdicionarCritica("Crítica - Pedido não pode ficar sem item!");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Crítica - CEP deve estar preenchido!");
            }
        }
    }
}
