using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : ObjetoGenerico
    {
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; } 
        public virtual string SobreNome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica - Nome deve estar preenchido!");
            }
            if (string.IsNullOrEmpty(SobreNome))
            {
                AdicionarCritica("Crítica - Nome deve estar preenchido!");
            }
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Crítica - Nome deve estar preenchido!");
            }

        }
    }
}
