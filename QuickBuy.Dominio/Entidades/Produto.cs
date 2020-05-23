using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : ObjetoGenerico
    {
        public virtual decimal Preco { get; set; }
        public override void Validate()
        {
            LimparMensagemValidacao();
            if (Id==0)
            {
                AdicionarCritica("Crítica - Id do Produto deve estar preenchido!");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica - Nome deve estar preenchido!");
            }
            if (Preco <= 0)
            {
                AdicionarCritica("Crítica - Preço do Produto deve ser maior que R$0.00!");
            }

        }
    }
}
