﻿using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : ObjetoGenerico
    {
        public string Email { get; set; }
        public string Senha { get; set; } 
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}