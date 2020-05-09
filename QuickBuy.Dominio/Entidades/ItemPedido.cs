using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : ObjetoGenerico
    {
        public int ProdutoId { get; set; }
        public int Quantidaded { get; set; }
    }
}
