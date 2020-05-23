
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class ObjetoGenerico
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }

        private List<string> _mensagemValidacao { get; set; }

        private List<string> mensagemValidacao {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>());}
        }
        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any();  }
        }
    }
}
