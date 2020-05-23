using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntinty> : IDisposable where TEntinty : class
    {
        void Adicionar(TEntinty entity);
        TEntinty ObterPorId(int id);
        IEnumerable<TEntinty> ObterTodos();
        void Atualizar(TEntinty identity);
        void Remover(TEntinty identity);
    }
}
