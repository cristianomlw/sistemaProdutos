using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Entities;

namespace Projeto.Data.Contracts
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        List<Produto> ObterPorNome(string nome);
    }
}
