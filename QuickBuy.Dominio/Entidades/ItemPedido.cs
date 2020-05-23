using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : ObjetoGenerico
    {

        public virtual int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }

        public virtual int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (ProdutoId == 0)
            {
                AdicionarCritica("Crítica - Produto deve estar preenchido!");
            }
            if (Quantidade <= 0)
            {
                AdicionarCritica("Crítica - Quantidade informada inválida!");
            }

        }
    }
}
